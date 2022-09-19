#pragma once
#include "AStar.hpp"
#include "Wave.hpp"
#include "Maze.hpp"
#include <string>
#include <iostream>
#include <fstream>

using namespace std;

class Interface {
private:
    string fileName = "2.txt";
    Maze maze;
    
    void setFile(string fileName);
    string getFile();
    
    void dataChoosing();
    void algoChoosing();
    void printStart();
    int cinInt();
    
public:
    Interface() {}
    void start();
    void printMaze();
};
