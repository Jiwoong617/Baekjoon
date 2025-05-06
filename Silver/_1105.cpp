#include <iostream>
#include <cmath>

using namespace std;

int main()
{
	int l, r, llen, rlen, ans = 0;
	cin >> l >> r;
	llen = log10(l) + 1;
	rlen = log10(r) + 1;

	if (llen == rlen)
	{
		while (llen--)
		{
			int m = max((int)pow(10, llen), 1);
			int ll = l / m, rr = r / m;
			l %= m; r %= m;

			if (ll != rr) break;
			if (ll == 8 && rr == 8) ans++;
		}
	}

	cout << ans;
	return 0;
}
