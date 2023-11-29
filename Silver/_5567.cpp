#include <set>
#include <map>
#include <queue>
#include <algorithm>
#include <iostream>
using namespace std;
int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	int n, t, count = 0; cin >> n >> t;
	int* man = new int[n+1] {0};
	map<int, set<int>> map;
	while (t--)
	{
		int a, b;
		cin >> a >> b;
		map[a].insert(b);
        map[b].insert(a);
	}

	queue<int> q; q.push(1);
	while (!q.empty())
	{
		int temp = q.front(); q.pop();

		for(auto a : map[temp])
		{
			if (a == 1 || man[a] > 0) continue;
			q.push(a);
			man[a] = man[temp] + 1;
		}
	}

	for (int i = 2; i <= n; i++)
		if (man[i] < 3 && man[i] > 0) count++;
	cout << count;
}
