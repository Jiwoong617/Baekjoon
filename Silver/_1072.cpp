#include <cmath>
#include <functional>
#include <iostream>
using namespace std;

int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	long long n, m, winRate;
	cin >> n >> m;
	winRate = floor(m * 100 / n);
	if (winRate > 98) { cout << -1; return 0; }

	long long l = 1, r = n, mid = 0;
	while (l < r)
	{
		mid = (l + r) / 2;
		int after = floor((m + mid) * 100 / (n + mid));
		if (after > winRate)
			r = mid;
		else
			l = mid+1;
	}
	cout << l;
}
