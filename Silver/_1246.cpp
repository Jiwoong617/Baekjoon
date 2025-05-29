#include <iostream>
#include <cmath>
#include <algorithm>

using namespace std;

int main()
{
	int n, m; cin >> n >> m;
	int* p = new int[m];
	for (int i = 0; i < m; i++)
		cin >> p[i];

	sort(p, p + m);
	int income = 0, idx = 0;
	for (int i = 0; i < m; i++)
	{
		if (p[i] * min(n, m - i) > income)
		{
			income = p[i] * min(n, m - i);
			idx = i;
		}
	}

	cout << p[idx] << ' ' << income;
	return 0;
}
