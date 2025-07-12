#include <iostream>
#include <unordered_set>
#include <vector>
#include <string>

using namespace std;

int n, k;
vector<int> v;
vector<bool> visited;
unordered_set<string> s;

void dfs(string num, int cnt)
{
	if (cnt == 0)
	{
		s.insert(num);
		return;
	}

	for (int i = 0; i < n; i++)
	{
		if (!visited[i])
		{
			visited[i] = true;
			dfs(num + to_string(v[i]), cnt - 1);
			visited[i] = false;
		}
	}
}

int main()
{
	cin >> n >> k;
	visited = vector<bool>(n);
	int a;
	for (int i = 0; i < n; i++)
	{
		cin >> a;
		v.push_back(a);
	}

	dfs("", k);

	cout << s.size();
	return 0;
}
