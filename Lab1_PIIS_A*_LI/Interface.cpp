#include "Interface.hpp"

void Interface::start()
{
    cout << "Hi, dear user!\n"
         << "It's an app which finds the path in maze.\n"
         << "If you want to try your maze - create your file txt with first row data: coordinates of start & end (4 numbers separated by a space\n"
         << "Next, fill your array where 1 is a wall and 0 is a walkway.\n"
         << "After all you can use one of algorithms: AStar or Wave.\n"
         << "Good luck!\n\n";
    
    dataChoosing();
    printStart();
    algoChoosing();
}

void Interface::dataChoosing()
{
    cout << "Choose 1 of 3 maze and write its number: ";
    int num;
    do {
        num = cinInt();
        if (num < 1 || num > 3) {
            cout << "Try number from 1 to 3: ";
        }
    } while(num < 1 || num > 3);
        
    setFile(to_string(num) + ".txt");
    ifstream file (fileName);
    
    if(file) {
        pair<int, int> coordinate;
        file >> coordinate.first;
        file >> coordinate.second;
        maze.setStart(coordinate);
        
        file >> coordinate.first;
        file >> coordinate.second;
        maze.setEnd(coordinate);
        
        vector<vector<int>> m;
        string line;
        getline(file, line);
        while (!file.eof()) {
            getline(file, line);
            vector<int> l;
            if (line.size() != 0) {
                for (int j = 0; j < line.size() - 1; j++) {
                    l.push_back((int)line[j] - 48);
                }
                m.push_back(l);
            }
        }
        maze.setMaze(m);
        file.close();
    }
    else {
        cout << "Unable to open file!" << endl;
    }
}

void Interface::printStart() {
    cout << "H = " << maze.getH() << endl;
    cout << "V = " << maze.getV() << endl;
    pair<int, int> coordinate = maze.getStart();
    cout << "Start: " << coordinate.first << "." << coordinate.second << endl;
    coordinate = maze.getEnd();
    cout << "End: " << coordinate.first << "." << coordinate.second << endl;
    printMaze();
}

void Interface::algoChoosing()
{
    cout << "Choose an algorithm:\n" << "(1) - AStar\n" << "(2) - Wave\n";
    int algo = 0;
    do {
        cout << "Try number 1 or 2:";
        algo = cinInt();
    } while (algo != 1 && algo != 2);
}


// SUB---------------------------------------------------------------------------------
void Interface::setFile(string fileName) {this->fileName = fileName;}
string Interface::getFile() {return fileName;}

int Interface::cinInt() {
    int num;
    cin >> num;
    while(cin.fail()) {
        cout << "Try to write a number: ";
        cin.clear();
        cin.ignore(256,'\n');
        cin >> num;
    }
    return num;
}

void Interface::printMaze() {
    vector<vector<int>> m = maze.getMaze();
    for (int i = 0; i < m.size() * 3 + 2; i++) {
        cout << "\u2500";                       // "-"
    }
    cout << endl;
    for (int i = 0; i < m.size(); i++) {
        cout << "\u2502";                       // "|"
        for (int j = 0; j < m[i].size(); j++) {
            if (i == maze.getStart().first && j == maze.getStart().second) {
                cout << " S ";                  // start
            }
            else if (i == maze.getEnd().first && j == maze.getEnd().second) {
                cout << " E ";                  // end
            }
            else if (m[i][j] == 1) {
                cout << "\u2588\u2588\u2588";   // "█"
            }
            else {
                cout << " \u2218 ";             // "∘"
            }
        }
        cout << "\u2502" << endl;               // "|"
    }
    for (int i = 0; i < m.size() * 3 + 2; i++) {
        cout << "\u2500";                       // "-"
    }
    cout << endl;
}