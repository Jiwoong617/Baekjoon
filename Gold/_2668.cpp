#include <iostream>
#include <algorithm>
#include <set>
#include <cmath>

using namespace std;

int n, a;
int* card;
bool* visited;
set<int> v;

void dfs(int num, int start)
{
	if (visited[num])
	{
		if (num == start)
			v.insert(num);
		return;
	}

	visited[num] = true;
	dfs(card[num], start);
}

int main()
{
	cin >> n;
	card = new int[n + 1]();

	for (int i = 1; i <= n; i++)
		cin >> card[i];

	for (int i = 1; i <= n; i++)
	{
		visited = new bool[n + 1]();
		dfs(i, i);
		delete[] visited;
	}

	cout << v.size() << endl;
	for (int i : v)
		cout << i << endl;
	
	return 0;
}
