#include <iostream>
#include <unordered_map>

using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);
	int t, n, a; cin >> t;
	while (t--)
	{
		unordered_map<int, bool> num;
		cin >> n;
		while (n--)
		{
			cin >> a;
			num.insert(make_pair(a, true));
		}

		cin >> n;
		while (n--)
		{
			cin >> a;
			cout << (num[a] ? "1\n" : "0\n");
		}
	}

	return 0;
}
