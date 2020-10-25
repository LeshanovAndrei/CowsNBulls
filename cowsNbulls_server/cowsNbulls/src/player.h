#pragma once
#include "header.h"

class Player
{
public:
	Player(SOCKET);
	Player();
	Player(const Player&);
	~Player();

	Player& operator=(const Player&);

	char* TryToAnswer();

	void SetName();
	std::string GetName();

	void Close();

	SOCKET GetConnection();
	void SetWins(int);
	int GetWins();
	void SetBulls(int);
	int GetBulls();
	void SetCows(int);
	int GetCows();

	char* GetMsg();
	void SendMsg(char*);


private:
	SOCKET connection;
	std::string name;
	int wins;
	int bulls;
	int cows;
};