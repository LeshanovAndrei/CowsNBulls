#include "stickman.h"
#include "header.h"


Stickman::Stickman()
{
	for (size_t i = 0; i < 5; i++)
	{
		answerNumber[i] = '\0';
	}
}


std::vector<int> Stickman::AnswerCheck(char* answ)//bulls and cows
{
	std::vector<int> reply;
	reply.push_back(0);
	reply.push_back(0);
	for (size_t i = 0; i < 4; i++)
	{
		int temp = find(answ[i]);
		if (temp == i)
		{
			reply[0]++;
		}
		else if (temp != -1)
		{
			reply[1]++;
		}
	}
	return reply;
}

char* Stickman::GetAnswerNumber()
{
	return answerNumber;
}
void Stickman::SetAnswerNumber(char* x)
{
	for (size_t i = 0; i < 5; i++)
	{
		answerNumber[i] = x[i];
	}
}
void Stickman::RandomizeAnswer()
{
	srand(static_cast<int>(time(0)));
	for (size_t i = 0; i < 5; i++)
	{

		int temp = rand() % 10;
		while (find(temp + 48) != -1)
		{
			temp = rand() % 10;
		}
		answerNumber[i] = 48 + temp;
	}
	answerNumber[4] = '\0';
}

int Stickman::find(char x)
{
	for (size_t i = 0; i < strlen(answerNumber); i++)
	{
		if (answerNumber[i] == x)
		{
			return i;
		}
	}
	return -1;
}