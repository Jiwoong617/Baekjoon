#include <iostream>
#include <algorithm>
#define ll long long

using namespace std;

int main() 
{
	int n, l, w, h; cin >> n >> l >> w >> h;

	double low = 0, high = min({ l,w,h });
	while (high > low)
	{
		double mid = (low + high) / 2.0;
		ll size = (ll)(l / mid) * (ll)(w / mid) * (ll)(h / mid);

		if (mid == high || mid == low) break;

		if (size < n)
			high = mid;
		else
			low = mid;
	}

	cout << fixed;
	cout.precision(9);
	cout << low;
	return 0;
}
