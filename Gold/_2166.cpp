#include <iostream>
#include <vector>
#include <cmath>

#define ld long double

using namespace std;

int n;
vector<pair<ld, ld>> v;
ld ans = 0;

int main()
{
	cin >> n;
	for (int i = 0;i < n; i++)
	{
		ld a, b;cin >> a >> b;
		v.push_back(make_pair(a, b));
	}

	for (int i = 0; i < n; i++)
	{
		ld a = v[i].first * v[(i + 1) % n].second;
		ld b = v[i].second * v[(i + 1) % n].first;
		ans += a - b;
	}
	ans = abs(ans) / 2;

	cout << fixed;
	cout.precision(1);
	cout << ans;

	return 0;
}
