#include <iostream>

using namespace std;

int badook[19][19];
bool visited[19][19][4] = { false, };
int dx[] = { 0, 1, 1 , 1};
int dy[] = { 1, 0, 1 , -1};
int x, y;

int dfs(int x, int y, int color, int dir, int count)
{
	visited[x][y][dir] = true;
	if ((x + dx[dir] < 19) && (y + dy[dir] < 19)
		&& (x + dx[dir] >= 0) && (y + dy[dir] >= 0)
		&& (badook[x + dx[dir]][y + dy[dir]] == color))
		count =  dfs(x + dx[dir], y + dy[dir], color, dir, count + 1);

	return count;
}

int main()
{
	for (int i = 0; i < 19; i++)
		for (int j = 0; j < 19; j++)
			cin >> badook[i][j];

	for (int i = 0; i < 19; i++)
		for (int j = 0; j < 19; j++)
		{
			if (badook[i][j])
			{
				int color = badook[i][j];
				for (int k = 0; k < 4; k++)
				{
					if (visited[i][j][k])
						continue;

					if (dfs(i, j, color, k, 1) == 5)
					{
						if(k != 3) { x = i + 1; y = j + 1; }
						else 
						{
							x = i + dx[3] * 4 + 1; 
							y = j + dy[3] * 4 + 1;
						}


						cout << color << '\n' << x << ' ' << y;
						return 0;
					}
				}
			}
		}

	cout << 0;

	return 0;
}
