#include <iostream>
#include <algorithm>
#include <vector>
using namespace std;

int main131A()
{
    char S[5];
    cin >> S;

    cout << (S[0] == S[1] || S[1] == S[2] || S[2] == S[3] ? "Bad" : "Good");
    return 0;
}
