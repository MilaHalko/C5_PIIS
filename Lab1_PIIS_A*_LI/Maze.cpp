#include "Maze.hpp"
void Maze::setMaze(vector<vector<int>> maze) {
    this->maze = maze;
//    sizeH = (int)maze.size();
//    sizeV = (int)maze[0].size();
//    for (int h = 0; h < sizeH; h++) {
//        vector<int> line;
//        for (int v = 0; v < sizeV; v++) {
//            line.push_back(maze[h][v]);
//        }
//        this->maze.push_back(line);
//    }
}
vector<vector<int>> Maze::getMaze() {return maze;}

int Maze::getV() {return (int)maze.size();}
int Maze::getH() {return (int)maze[0].size();}

void Maze::setStart(pair<int, int> start) {this->start = start;}
void Maze::setEnd(pair<int, int> end) {this->end = end;}
pair<int, int> Maze::getStart() {return start;}
pair<int, int> Maze::getEnd() {return end;}
