#include <iostream>
#include <set>
#include <algorithm>

using namespace std;

int main()
{
	int n, m, a, b; cin >> n >> m;
	set<int> sa, sb, ans;
	while (n--)
	{
		cin >> a;
		sa.insert(a);
	}
	while (m--)
	{
		cin >> b;
		sb.insert(b);
	}

	set_difference(sa.begin(), sa.end(), sb.begin(), sb.end(), inserter(ans, ans.end()));

	if (ans.size() == 0)
		cout << 0;
	else
	{
		cout << ans.size() << '\n';
		for (auto i = ans.begin(); i!= ans.end(); i++)
			cout << *i << ' ';
	}

	return 0;
}
