#include <iostream>
#include <algorithm>
#include <string>

using namespace std;

pair<int, int> direction(string s)
{
	if (s == "R") return make_pair(0, 1);
	else if (s == "L") return make_pair(0, -1);
	else if (s == "B") return make_pair(-1, 0);
	else if (s == "T") return make_pair(1, 0);
	else if (s == "RT") return make_pair(1, 1);
	else if (s == "RB") return make_pair(-1, 1);
	else if (s == "LT") return make_pair(1, -1);
	else if (s == "LB") return make_pair(-1, -1);
}

bool check(int x, int y)
{
	return (x >= 0 && y >= 0 && x < 8 && y < 8);
}

int main()
{
	int n, kingX, kingY, stoneX, stoneY;
	string king, stone;
	cin >> king >> stone >> n;
	kingX = king[1] - '1'; kingY = king[0] - 'A';
	stoneX = stone[1] - '1'; stoneY = stone[0] - 'A';

	while (n--)
	{
		string s; cin >> s;
		pair<int, int> dir = direction(s);
		int tempX = dir.first + kingX;
		int tempY = dir.second + kingY;

		if (!check(tempX, tempY)) continue;

		if (tempX == stoneX && tempY == stoneY)
		{
			if (!check(stoneX + dir.first, stoneY + dir.second)) continue;

			stoneX += dir.first;
			stoneY += dir.second;
		}
		kingX += dir.first;
		kingY += dir.second;
	}

	cout << (char)(kingY + 'A') << (char)(kingX + '1') << '\n';
	cout << (char)(stoneY + 'A') << (char)(stoneX + '1');
}
