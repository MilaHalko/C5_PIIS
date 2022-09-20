#pragma once
#include "Maze.hpp"
#include <queue>

class AStar {
private:
    Maze maze;
    bool checkCellValidation(int, int, Cell);
    void addAdjs (pair<Cell, int>, priority_queue<Cell, int>);
    int countHeuristic(int, int, int, Cell);
    list<Cell> redoPath(Cell);
public:
    AStar(Maze maze);
    int start();
};

