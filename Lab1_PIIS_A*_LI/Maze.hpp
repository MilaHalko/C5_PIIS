#pragma once
#include <vector>
#include <string>
#include <fstream>
#include <list>
#include "Cell.hpp"

using namespace::std;

class Maze {
private:
    vector<vector<Cell>> maze;
    list<Cell> path;
    Cell start;
    Cell end;
    
public:
    Maze();
    void setMaze(vector<vector<Cell>>);
    vector<vector<Cell>> getMaze();
    
    void addToPath(Cell cell);
    list<Cell> getPath();
    
    int getHi();
    int getWi();
    
    void setStart(int, int);
    void setEnd(int, int);
    Cell getStart();
    Cell getEnd();
 
};
