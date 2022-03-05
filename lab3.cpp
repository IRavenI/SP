#include <iostream>

#include <string>

#include <fstream>

#include "Windows.h"
using namespace std;

int main()

{
	
std::string name;
std::cout << "Enter your name: ";
std::cin >> name;
std::cout << "Hello, " << name << "\n";
std::cout << "Your ip address is:";	
SetConsoleCP(1251);
SetConsoleOutputCP(1251);
setlocale(LC_ALL, "Russian");
string line;

ifstream IPFile;

int offset;

char* search0 = "IPv4-"; // search pattern

system("ipconfig > ip.txt");

IPFile.open ("ip.txt");

if(IPFile.is_open())

{

while(!IPFile.eof())

{

getline(IPFile,line);

if ((offset = line.find(search0, 0)) != string::npos)

{

// IPv4 Address. . . . . . . . . . . : 1

//1234567890123456789012345678901234567890

line.erase(0,39);

cout << line << endl;

IPFile.close();

}

}

}

return 0;

}