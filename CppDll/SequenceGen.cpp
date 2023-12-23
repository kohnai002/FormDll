#include "pch.h"
#include "SequenceGen.h"

/* Class methods */

void sequenceGen::loadNumber(int seqNum)
{
	if (seqNum >= 0)
	{
		sequenceNum = seqNum;
	}
}

int sequenceGen::getNumber()
{
	return sequenceNum;
}

int sequenceGen::counting_sequence()
{
	return sequenceNum;
}

int sequenceGen::fibonacci_sequence()
{
	int fib_current = 0;
	int fib_next = 1;
	int fib_temp = 0;

	for (int i = 0; i < sequenceNum; i++)
	{
		// calculate next next number (current +2 sequence)
		fib_temp = fib_current + fib_next;

		// update current to +1
		fib_current = fib_next;

		// update +1 value to +2
		fib_next = fib_temp;
	}

	return fib_current;
}

int sequenceGen::factorial_sequence()
{
	int currentNum = 1;

	if (sequenceNum == 0)
	{
		return currentNum;
	}
	
	for (int i = 1; i <= sequenceNum; i++)
	{
		currentNum = currentNum * i;
	}
	
	return currentNum;
}