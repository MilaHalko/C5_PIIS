#include "Maze.hpp"
void Maze::setMaze(vector<vector<Cell>> maze) {
    this->maze = maze;
}
vector<vector<Cell>> Maze::getMaze() {
    return maze;
}

void Maze::addToPath(Cell cell) {
    path.push_back(cell);
}
list<Cell> Maze::getPath() {
    return path;
}

int Maze::getHi() {return (int)maze.size();}
int Maze::getWi() {return (int)maze[0].size();}

void Maze::setStart(int x, int y) {
    start = Cell(x, y);
}
void Maze::setEnd(int x, int y) {
    end = Cell(x, y);
}
Cell Maze::getStart() {return start;}
Cell Maze::getEnd() {return end;}
