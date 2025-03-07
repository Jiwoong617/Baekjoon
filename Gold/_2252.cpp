#include <algorithm>
#include <unordered_map>
#include <vector>
#include <iostream>
using namespace std;

unordered_map<int, vector<int>> graph;
bool* visited;

void dfs(int val)
{
	for (auto a : graph[val])
	{
		if (visited[a] == false)
		{
			visited[a] = true;
			dfs(a);
		}
	}

	cout << val << ' ';
}

int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	int n, m, a, b;
	cin >> n >> m;
	visited = new bool[n + 1]();


	for (int i = 0; i < m; i++)
	{
		cin >> a >> b;
		graph[b].push_back(a);
	}


	for (int i = 1; i<n+1; i++)
	{
		if (!visited[i])
		{
			visited[i] = true;
			dfs(i);
		}
	}

	return 0;
}
