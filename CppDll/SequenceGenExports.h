#pragma once
#include "SequenceGen.h"

#ifndef CPPDLL_EXPORTS
#define CPPDLL_API __declspec(dllexport)
#else
#define CPPDLL_API __declspec(dllimport)
#endif

extern "C" sequenceGen * seqGen_Create() { return new sequenceGen(); }

extern "C" void seqGen_Delete(sequenceGen * seqPtr) { delete seqPtr; }

extern "C" void seqGen_Load(sequenceGen * seqPtr, int num) { seqPtr->loadNumber(num); }

extern "C" int seqGen_GetNum(sequenceGen * seqPtr) { return seqPtr->getNumber(); }

extern "C" int seqGen_countSeq(sequenceGen * seqPtr) { return seqPtr->counting_sequence(); }

extern "C" int seqGen_fibSeq(sequenceGen * seqPtr) { return seqPtr->fibonacci_sequence(); }

extern "C" int seqGen_factSeq(sequenceGen * seqPtr) { return seqPtr->factorial_sequence(); }
