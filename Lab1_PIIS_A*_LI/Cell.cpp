#include "Cell.hpp"
Cell::Cell(int x, int y) {
    coord = make_pair(x, y);
}
Cell::Cell(int x, int y, int dist): Cell(x, y) {
    this->dist = dist;
}

void Cell::setDist(int d) {
    dist = d;
}
int Cell::getDist() {
    return dist;
}

int Cell::getX() {
    return coord.first;
}
int Cell::getY() {
    return coord.second;
}
pair<int, int> Cell::getCoord() {
    return coord;
}

void Cell::setParent(int x, int y) {
    parent = make_pair(x, y);
}
pair<int, int> Cell::getParent() {
    return parent;
}
