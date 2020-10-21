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
	char temp[32]; //Получим сначала размер сообщения, которое хотим получить
	recv(connection, temp, sizeof(temp), NULL);

	char* msg = new char[atoi(temp)];
	recv(connection, msg, sizeof(msg), NULL);
	return msg;
}
void Player::SendMsg(char* msg)
{
	char temp[32];
	itoa(sizeof(msg), temp, 10);
	send(connection, temp, sizeof(temp), NULL);
	send(connection, msg, atoi(temp), NULL);

}