#include <iostream>
#include <unordered_map>
#include <algorithm>

using namespace std;

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	long long t, n; cin >> t;
	while (t--)
	{
		cin >> n;
		unordered_map<long long, long long> m;
		long long a;
		for (int i = 0; i < n; i++)
		{
			cin >> a;
			m[a]++;
		}

		auto it = max_element(m.begin(), m.end(), [](const auto& a, const auto& b)
			{
				return a.second < b.second;
			});

		if (it->second > (long long)(n / 2))
			cout << it->first << '\n';
		else
			cout << "SYJKGW\n";
	}

	return 0;
}
