#include <iostream>

using namespace std;

int main()
{
	int n, m, j, a;
	cin >> n >> m >> j;

	int l = 1, r = m, ans = 0;
	while (j--)
	{
		cin >> a;
		if (a >= l && a <= r)
			continue;

		if (a < l)
		{
			ans += l - a;
			l = a;
			r = l + m - 1;
		}
		else
		{
			ans += a - r;
			r = a;
			l = r - m + 1;
		}
	}

	cout << ans;
	return 0;
}
