#include <iostream>
#include <unordered_map>
#include <vector>
#include <algorithm>

using namespace std;

int n, m, a, b;
unordered_map<int, vector<int>> tall;
unordered_map<int, vector<int>> small;
int* visited;
bool* visited2;


void dfs_tall(int num, int start)
{
	for (int next : tall[num])
	{
		if (visited2[next])
			continue;

		visited2[next] = true;
		visited[start]++;
		dfs_tall(next, start);
	}
}

void dfs_small(int num, int start)
{
	for (int next : small[num])
	{
		if (visited2[next])
			continue;

		visited2[next] = true;
		visited[start]++;
		dfs_small(next, start);
	}
}

int main()
{
	cin >> n >> m;
	visited = new int[n + 1]();

	while (m--)
	{
		cin >> a >> b;
		tall[a].push_back(b);
		small[b].push_back(a);
	}
	
	for (int i = 1; i <= n; i++)
	{
		visited2 = new bool[n + 1]();
		dfs_tall(i, i);
		delete[] visited2;

		visited2 = new bool[n + 1]();
		dfs_small(i, i);
		delete[] visited2;
	}

	cout << count(visited + 1, visited + (n + 1), n - 1);

	return 0;
}
