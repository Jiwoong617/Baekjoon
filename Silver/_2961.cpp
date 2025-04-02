#include <iostream>
#include <vector>
#include <cmath>
#include <algorithm>
#include <climits>

using namespace std;

int sour = 1, bitter = 0, ans = INT_MAX;
int n, a, b;
vector<pair<int, int>> v;

void backT(int num)
{
	sour *= v[num].first;
	bitter += v[num].second;
	ans = min(ans, abs(sour - bitter));

	for (int i = num+1; i < n; i++)
		backT(i);

	sour /= v[num].first;
	bitter -= v[num].second;
}

int main()
{
	cin >> n;
	for (int i = 0; i < n; i++)
	{
		cin >> a >> b;
		v.push_back(make_pair(a,b));
	}

	for (int i = 0; i < n; i++)
		backT(i);

	cout << ans;
	return 0;
}
