#include <iostream>
#include <vector>
#include <queue>
#include <map>
#include <algorithm>

using namespace std;

int main()
{
	int n, m; cin >> n >> m;
	map<int, vector<int>> farm;
	vector<int> v(n + 1, -1);
	queue<int> q;

	while (m--)
	{
		int a, b; cin >> a >> b;
		farm[a].push_back(b);
		farm[b].push_back(a);
	}

	q.push(1);
	v[1] = 0;
	while (!q.empty())
	{
		int t = q.front();
		q.pop();

		for (int next : farm[t])
		{
			if (v[next] == -1)
			{
				v[next] = v[t] + 1;
				q.push(next);
			}
		}
	}

	cout << max_element(v.begin(), v.end()) - v.begin() << ' '
		<< *max_element(v.begin(), v.end()) << ' '
		<< count(v.begin(), v.end(), *max_element(v.begin(), v.end()));

	return 0;
}
