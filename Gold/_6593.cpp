#include <iostream>
#include <vector>
#include <string>
#include <tuple>
#include <queue>

using namespace std;

int main()
{
	int dz[] = { -1, 1, 0, 0, 0, 0 };
	int dx[] = { 0, 0, -1, 1, 0 ,0 };
	int dy[] = { 0, 0, 0, 0, -1, 1 };

	int l, r, c;
	cin >> l >> r >> c;
	while (l != 0 || r != 0 || c != 0)
	{
		vector<vector<string>> v(l, vector<string>(r));
		vector<vector<vector<int>>> visited(l, vector<vector<int>>(r, vector<int>(c, -1)));
		tuple<int, int, int> start;
		for (int i = 0; i < l; i++)
			for (int j = 0; j < r; j++)
			{
				cin >> v[i][j];
				for (int k = 0; k < c; k++)
					if (v[i][j][k] == 'S')
						start = make_tuple(i, j, k);
			}

		bool reached = false;
		queue<tuple<int, int, int>> q;
		q.push(start);
		visited[get<0>(start)][get<1>(start)][get<2>(start)] = 0;
		while (!q.empty())
		{
			tuple<int, int, int> temp = q.front();
			q.pop();

			if (v[get<0>(temp)][get<1>(temp)][get<2>(temp)] == 'E')
			{
				cout << "Escaped in " << visited[get<0>(temp)][get<1>(temp)][get<2>(temp)] << " minute(s).\n";
				reached = true;
				break;
			}

			for (int i = 0; i < 6; i++)
			{
				int z = get<0>(temp) + dz[i];
				int x = get<1>(temp) + dx[i];
				int y = get<2>(temp) + dy[i];

				if (z < 0 || x < 0 || y < 0 ||
					z >= l || x >= r || y >= c ||
					visited[z][x][y] > -1 ||
					v[z][x][y] == '#')
					continue;

				q.push(make_tuple(z, x, y));
				visited[z][x][y] = visited[get<0>(temp)][get<1>(temp)][get<2>(temp)] + 1;
			}
		}

		if (!reached) cout << "Trapped!\n";
		cin >> l >> r >> c;
	}

	return 0;
}
