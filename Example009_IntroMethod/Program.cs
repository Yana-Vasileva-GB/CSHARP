﻿int a1 = 2;
int b1 = 54;
int c1 = 57;
int a2 = 26;
int b2 = 44;
int c2 = 27;
int a3 = 25;
int b3 = 53;
int c3 = 176;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);