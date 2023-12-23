#pragma once

#ifndef CPPDLL_EXPORTS
#define CPPDLL_API __declspec(dllexport)
#else
#define CPPDLL_API __declspec(dllimport)
#endif

// define the class (not exported)
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

// define and export interface functions
extern "C" __declspec(dllexport) sequenceGen * seqGen_Create() { return new sequenceGen(); }
extern "C" __declspec(dllexport) void seqGen_Delete(sequenceGen * seqPtr) { delete seqPtr; }
extern "C" __declspec(dllexport) void seqGen_Load(sequenceGen * seqPtr, int num) { seqPtr->loadNumber(num); }
extern "C" __declspec(dllexport) int seqGen_GetNum(sequenceGen * seqPtr) { return seqPtr->getNumber(); }
extern "C" __declspec(dllexport) int seqGen_countSeq(sequenceGen * seqPtr) { return seqPtr->counting_sequence(); }
extern "C" __declspec(dllexport) int seqGen_fibSeq(sequenceGen * seqPtr) { return seqPtr->fibonacci_sequence(); }
extern "C" __declspec(dllexport) int seqGen_factSeq(sequenceGen * seqPtr) { return seqPtr->factorial_sequence(); }