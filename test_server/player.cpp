#include "player.h"
#include "header.h"

Player::Player(SOCKET newConnection) :
	wins(0),
	bulls(0),
	cows(0),
	connection(newConnection)
{

}
Player::~Player()
{
	shutdown(connection, 2);
	closesocket(connection);
}

char* Player::TryToAnswer()
{
	return GetMsg();
}

void Player::SetName()
{
	name = GetMsg();
}
std::string Player::GetName()
{
	return name;
}

SOCKET Player::GetConnection()
{
	return connection;
}
void Player::SetWins(int x)
{
	wins = x;
}
int Player::GetWins()
{
	return wins;
}
void Player::SetBulls(int x)
{
	bulls = x;
}
int Player::GetBulls()
{
	return bulls;
}
void Player::SetCows(int x)
{
	cows = x;
}
int Player::GetCows()
{
	return cows;
}


char* Player::GetMsg()
{
	char temp[2]; //Получим сначала размер сообщения, которое хотим получить
	recv(connection, temp, sizeof(temp), NULL);
	temp[1] = '\0';
	int n = temp[0];
	if (n < 1)
	{
		exit(1);
	}
	std::cout << n<<'\n';
	char* msg = new char[n+1];
	recv(connection, msg, n, NULL);
	msg[n] = '\0';
	return msg;
}
void Player::SendMsg(char* msg)
{
	char temp[2];
	//itoa(sizeof(msg)/sizeof(char), temp, 10);
	temp[0] = strlen(msg);
	temp[1] = 0;
	send(connection, temp, 2, NULL);
	send(connection, msg, temp[0], NULL);

}