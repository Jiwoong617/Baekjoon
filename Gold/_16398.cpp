#include <algorithm>
#include <vector>
#include <cmath>
#include <functional>
#include <queue>
#include <iostream>
using namespace std;

struct planet
{
	int now;
	int next;
	int cost;
	planet(int a, int b, int c) : now(a), next(b), cost(c) { }
};
struct cmp
{
	bool operator()(planet a, planet b)
	{
		return a.cost > b.cost; //cmp 구조체는 반대임
	}
};

int parent[1001] = { 0 };

int findP(int n)
{
	if (parent[n] == n)
		return n;
	return parent[n] = findP(parent[n]);
}

bool makeUnion(int a, int b)
{
	int a1 = findP(a);
	int b1 = findP(b);

	if (a1 == b1)
		return false;

	if (a1 > b1)
		parent[a1] = b1;
	else
		parent[b1] = a1;
	return true;
}

int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	int n;
	cin >> n;

	priority_queue<planet, vector<planet>, cmp> pq;

	int num;
	for (int i = 1; i <=n;i++)
	{
		for (int j = 1; j <= n; j++)
		{
			cin >> num;
			if (j > i)
				pq.push(planet(i, j, num));
		}
		parent[i] = i;
	}

	long long ans = 0;
	while (!pq.empty())
	{
		planet p = pq.top(); pq.pop();
		if (makeUnion(p.now, p.next))
			ans += p.cost;
	}
	cout << ans;
}
