#include "header.h"
#include "player.h"
#include "stickman.h"


bool compar(Player a, Player b) {

	return a.GetWins() > b.GetWins();

}

int main(int argc, char* argv[])
{
	if (argc < 3)
	{
		std::cout << "Error! Not enough parametrs!\n";
		return 1;
	}
	int numOfPlayers = atoi(argv[1]);
	int numOfRounds = numOfPlayers;
	bool comp = atoi(argv[2]);
	if (numOfPlayers < 2)
	{
		comp = true;
	}
	std::cout << "Server started for " << numOfPlayers << " players\n";

	std::vector<Player> players;
	Stickman stickman;

	WSAData wsaData;
	WORD DLLVersion = MAKEWORD(2, 1);
	if (WSAStartup(DLLVersion, &wsaData))
	{
		std::cout << "Error\n";
		return 1;
	}
	SOCKADDR_IN addr;
	int sizeofaddr = sizeof(addr);
	addr.sin_addr.s_addr = inet_addr("127.0.0.1");
	addr.sin_port = htons(1111);
	addr.sin_family = AF_INET;


	//Подключение игроков
	SOCKET sListen = socket(AF_INET, SOCK_STREAM, NULL);
	bind(sListen, (SOCKADDR*)&addr, sizeof(addr));
	listen(sListen, SOMAXCONN);
	std::cout << "Waiting for connections...\n";
	SOCKET newConnection;
	for (size_t i = 0; i < numOfPlayers; i++)
	{
		newConnection = accept(sListen, (SOCKADDR*)&addr, &sizeofaddr);

		if (!newConnection)
		{
			std::cout << "Error!\n";
		}
		else
		{
			std::cout << "Client Connected!\n";
			players.push_back(*new Player(newConnection));

		}

	}
	std::cout << numOfPlayers << " players conected!\n";
	if (comp)
	{
		stickman.RandomizeAnswer();
		std::cout << "Answer generated!\n";
	}


	//Фаза регистрации
	/*
	Как только клиенты подключились, ждем от них данных для имен
	*/
	for (size_t i = 0; i < numOfPlayers; i++)
	{
		players[i].SetName();
	}

	//Пошлем количество игроков
	for (size_t i = 0; i < numOfPlayers; i++)
	{
		char msg[2];
		itoa(numOfPlayers, msg, 10);
		players[i].SendMsg(msg);
	}

	/*
	Теперь нужно отправить всем игрокам имена остальных
	*/
	for (size_t i = 0; i < numOfPlayers; i++)
	{
		for (size_t j = 0; j < numOfPlayers; j++)
		{
			char msg[32];
			msg[0] = j + 48;
			msg[1] = ' ';
			strcat(msg, players[j].GetName().c_str());
			players[i].SendMsg(msg);
		}

	}

	//Отправим флажок, участвует ли сервер в загадывании числа
	for (size_t i = 0; i < numOfPlayers; i++)
	{
		char msg[2];
		itoa(comp, msg, 2);
		players[i].SendMsg(msg);
	}

	//Сам игровой процесс
	for (size_t i = 0; i < numOfRounds; i++)
	{
		bool victory = false;
		if (!comp)
		{
			for (size_t c = 0; c < numOfPlayers; c++)
			{
				char msg[2];
				itoa(i, msg, 2);
				players[c].SendMsg(msg);
			}
			stickman.SetAnswerNumber(players[i].GetMsg());
		}

			while (!victory)//Пока не победа продолжай опрашивать
			{
				for (size_t j = 0; j < numOfPlayers; j++)//Опрашивай всех по очереди
				{
					if (comp and j == i)
					{
						continue;
					}
					//Скажем всем, от кого мы ждем ответа
					for (size_t c = 0; c < numOfPlayers; c++)
					{
						char msg[2];
						itoa(j, msg, 2);
						players[i].SendMsg(msg);
					}
					//Получим ответ
					char* reply = players[j].GetMsg();
					//Проверяем ответ от j-го игрока
					int bulls = stickman.AnswerCheck(reply)[0];
					int cows = stickman.AnswerCheck(reply)[1];
					//обновим статистику ответившего
					players[j].SetBulls(players[j].GetBulls() + bulls);
					players[j].SetCows(players[j].GetCows() + cows);
					//Создание сообщения ответа и реакции
					char msgTo[12];
					for (size_t f = 0; f < 4; f++)
					{
						msgTo[f] = reply[f];
					}
					strcat(msgTo, " ");
					char buff[2];
					strcat(msgTo, itoa(bulls, buff, 10));
					strcat(msgTo, " ");
					char buff2[2];
					strcat(msgTo, itoa(cows, buff2, 10));
					//Отсылаем ответ игрока и реакцию на него
					for (size_t n = 0; n < numOfPlayers; n++)
					{
						players[n].SendMsg(msgTo);
					}
					//проверим на победу
					if (bulls == 4)
					{
						players[j].SetWins(players[j].GetWins() + 1);
						victory = true;
						//Отошлем всем сообщение о конце раунда
						for (size_t n = 0; n < numOfPlayers; n++)
						{
							char vMsg[2] = "V";
							players[n].SendMsg(vMsg);
						}
						break;
					}

				}
			}
	}

	//Формирование и отправка таблицы результатов
	std::sort(players.begin(), players.end(), compar);
	for (size_t i = 0; i < numOfPlayers; i++)
	{
		for (size_t j = 0; j < numOfPlayers; j++)
		{
			char msg[256];
			msg[0] = j + 48;
			msg[1] = ' ';
			strcat(msg, players[j].GetName().c_str());
			strcat(msg, " ");
			char temp[32];
			itoa(players[j].GetWins(), temp, 10);
			strcat(msg, temp);
			players[i].SendMsg(msg);
		}
	}

	shutdown(newConnection, 2);
	shutdown(sListen, 2);
	closesocket(newConnection);
	closesocket(sListen);
	return 0;
}