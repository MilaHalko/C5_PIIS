#pragma once
#include <iostream>
using namespace std;

class Cell {
    int dist;
    pair<int, int> coord;
    pair<int, int> parent; 
public:
    Cell(int x, int y);
    Cell(int x, int y, int value);
    
    void setDist(int);
    int getDist();
    
    int getX();
    int getY();
    pair<int, int> getCoord();
    
    void setParent(int, int);
    pair<int, int> getParent();
};
