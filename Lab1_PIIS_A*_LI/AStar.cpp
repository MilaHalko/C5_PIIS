#include "AStar.hpp"

AStar::AStar(Maze maze) {
    this->maze = maze;
}

int AStar::start() {
    priority_queue<Cell, int> cellsQueue;
    cellsQueue.push(maze.getStart());
    
    while (cellsQueue.size() > 0) {
        pair<Cell, int> high = cellsQueue.top();
        if (high.first.getX() == maze.getEnd().getX() && high.first.getY() == maze.getEnd().getY()) {
            redoPath(high.first);
            return high.first.getDist();
        }
        addAdjs(high, cellsQueue);
    }
    return -1;
}

int AStar::countHeuristic(int fullDist, int row, int col, Cell end) {
    int sum = fullDist;
    sum += (abs(end.getX() - col) - 1) * 10;
    sum += (abs(end.getY() - row) - 1) * 10;
    return sum;
}
bool AStar::checkCellValidation(int row, int col, Cell parent) {
    return row > 0 && col > 0 && row < maze.getHi() && col < maze.getWi() &&
           maze.getMaze()[row][col].getDist() > 0  &&
           !(parent.getX() == col && parent.getY() == row);
}


list<Cell> AStar::redoPath(Cell cell) {
    maze.addToPath(cell);
    while (cell.getDist() != 0) {
        cell = maze.getMaze()[cell.getParent().first][cell.getParent().second];
        maze.addToPath(cell);
    }
    list<Cell> path = maze.getPath();
    path.reverse();
    return path;
}

void AStar::addAdjs(pair<Cell, int> parent, priority_queue<Cell, int> cQueue) {
    Cell p = parent.first;
    bool diagonal = true;
    for (int row = p.getY() - 1; row < p.getY() + 2; row++) {
        for (int col = p.getX() - 1; col < p.getX() + 2; col++) {
            if (checkCellValidation(row, col, parent.first)) {
                Cell c = maze.getMaze()[row][col];
                c.setParent(p.getX(), p.getY());
                int dist = diagonal? 14 : 10;
                c.setDist(dist);
                cQueue.push(c, (countHeuristic(c.getDist(), row, col, maze.getEnd())));
                diagonal = !diagonal;
            }
        }
    }
}
