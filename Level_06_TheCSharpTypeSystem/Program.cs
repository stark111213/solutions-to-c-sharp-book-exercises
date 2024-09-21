// -------------------- The Variable Shop --------------------

int i = -2_147_483_648;
uint ui = 4_294_967_295;

short sh = 32_767;
ushort us = 65_535;

long l = 9_223_372_036_854_775_807;
ulong ul = 18_446_744_073_709_551_615;

byte by = 255;
sbyte sb = 127;

char c = '\u0061';
string s = "string";

float f = 3.0f;
double d = 2.2;
decimal m = 3.3M;

bool b = true;

int hex = 0x001;
int binary = 0b1100;

// Display
WriteLine(i);
WriteLine(sh);
WriteLine(l);
WriteLine(by);
WriteLine(sb);
WriteLine(ul);
WriteLine(ui);
WriteLine(us);

WriteLine(c);
WriteLine(s);

WriteLine(f);
WriteLine(d);
WriteLine(m);

WriteLine(b);

WriteLine(hex);
WriteLine(binary);

// -------------------- The Variable Shop Returns --------------------

i = -2_147_48368;
sh = 32_767;
l = 9_223_372_03854_775_807;
by = 255;
sb = 127;
ui = 4_294_967_25;
us = 65_535;
ul = 18_446_744_03_709_551_615;

c = '\u0081';
s = "another";

f = 32.0f;
d = 22.2;
m = 32.3M;

b = true;

hex = 0x0021;
binary = 0b10100;

WriteLine("\n---------- New Values ----------\n");

// Display
WriteLine(i);
WriteLine(sh);
WriteLine(l);
WriteLine(by);
WriteLine(sb);
WriteLine(ui);
WriteLine(ul);
WriteLine(us);

WriteLine(c);
WriteLine(s);

WriteLine(f);
WriteLine(d);
WriteLine(m);

WriteLine(b);

WriteLine(hex);
WriteLine(binary);
