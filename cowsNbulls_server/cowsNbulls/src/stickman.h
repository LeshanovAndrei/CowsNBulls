#pragma once
#include "header.h"

class Stickman
{
public:
	Stickman();
	std::vector<int> AnswerCheck(char*);

	char* GetAnswerNumber();
	void SetAnswerNumber(char*);
	void RandomizeAnswer();
private:
	char answerNumber[5];

	int find(char);
};