#pragma once

// define the class
class sequenceGen
{
private:
	int sequenceNum = 0;
public:
	void loadNumber(int seqNum);
	int getNumber();
	int counting_sequence();
	int fibonacci_sequence();
	int factorial_sequence();
};