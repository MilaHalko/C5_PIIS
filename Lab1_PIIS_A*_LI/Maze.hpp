#pragma once
#include <vector>
#include <string>
#include <fstream>
#include <list>

using namespace::std;

class Maze {
private:
    vector<vector<int>> maze;
    list<pair<int, int>> path;
    pair<int, int> start;
    pair<int, int> end;
    
public:
    void setMaze(vector<vector<int>>);
    vector<vector<int>> getMaze();
    int getV();
    int getH();
    void setStart(pair<int, int>);
    void setEnd(pair<int, int>);
    pair<int, int> getStart();
    pair<int, int> getEnd();
 
};
