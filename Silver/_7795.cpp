#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

int t;

int main()
{
	cin >> t;
	while (t--)
	{
		int n, m, a, b, ans = 0;
		cin >> n >> m;
		vector<int> v1, v2;
		while (n--)
		{
			cin >> a;
			v1.push_back(a);
		}

		while(m--)
		{
			cin >> b;
			v2.push_back(b);
		}
		sort(v1.begin(), v1.end());
		sort(v2.begin(), v2.end());

		for (int i : v2)
		{
			auto it = upper_bound(v1.begin(), v1.end(), i);

			if (it != v1.end())
			{
				int idx = it - v1.begin();
				ans += (v1.size() - idx);
			}
		}

		cout << ans << "\n";
	}

	return 0;
}
