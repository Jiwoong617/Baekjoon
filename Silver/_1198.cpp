#include <iostream>
#include <cmath>

using namespace std;

int nerB(pair<int,int> a, pair<int, int> b, pair<int, int> c)
{
	return abs(a.first * b.second + b.first * c.second 
		+ c.first * a.second - b.first * a.second 
		- c.first * b.second - a.first * c.second);
}

int main()
{
	int n, a, b, ans = 0; cin >> n;
	pair<int, int>* p = new pair<int,int>[n];
	for (int i = 0; i < n; i++)
	{
		cin >> a >> b;
		p[i] = make_pair(a, b);
	}

	for (int i = 0; i < n; i++)
		for (int j = i + 1; j < n; j++)
			for (int k = j + 1; k < n; k++)
				ans = max(ans, nerB(p[i], p[j], p[k]));

	cout.precision(9);
	cout << fixed;
	cout << (double)ans * 0.5f;
	return 0;
}
