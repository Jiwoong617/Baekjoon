#include <iostream>
#include <vector>
#include <unordered_map>
#include <cstring>

using namespace std;

unordered_map<int, vector<pair<int, int>>> graph;
bool visited[10001];

void dfs(int start, int end, int dist)
{
	visited[start] = true;
	if (start == end)
	{
		cout << dist << '\n';
		return;
	}

	for (pair<int, int> a : graph[start])
	{
		if (visited[a.first]) continue;

		dfs(a.first, end, dist + a.second);
	}
}

int main()
{
	int n, m;
	cin >> n >> m;
	for (int i = 1; i < n; i++)
	{
		int a, b, c;
		cin >> a >> b >> c;
		graph[a].push_back(make_pair(b, c));
		graph[b].push_back(make_pair(a, c));
	}

	while (m--)
	{
		int a, b; cin >> a >> b;
		memset(visited, false, sizeof(bool) * 10001);
		dfs(a, b, 0);
	}
	return 0;
}
