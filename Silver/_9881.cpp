#include <vector>
#include <iostream>
#include <cmath>
#include <climits>
using namespace std;

int main()
{
	int n, m, ans = INT_MAX; cin >> n;
	vector<int> v;
	for (int i = 0; i < n; i++)
	{
		cin >> m;
		v.push_back(m);
	}

	for (int i = 0; i <= 83; i++)
	{
		int temp = 0;
		for (int j = 0; j < n; j++)
		{
			if (v[j] < i) temp += pow(i - v[j], 2);
			if (v[j] > i + 17) temp += pow(v[j] - i - 17, 2);
		}
		ans = min(ans, temp);
	}
	cout << ans;
	return 0;
}
