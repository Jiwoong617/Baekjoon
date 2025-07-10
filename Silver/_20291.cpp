#include <iostream>
#include <string>
#include <algorithm>
#include <map>

using namespace std;

int main()
{
	int n; cin >> n;
	map<string, int> m;
	while (n--)
	{
		string s; cin >> s;
		int idx = s.find('.') + 1;
		m[s.substr(idx)]++;
	}

	for (auto a : m)
		cout << a.first << ' ' << a.second << '\n';
	return 0;
}
