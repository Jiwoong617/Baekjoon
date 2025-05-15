#include <iostream>
#include <string>
#include <regex>

using namespace std;

int main()
{
	int n; cin >> n;
	while (n--)
	{
		string s; cin >> s;
		regex p("(100+1+|01)+");
		cout << (regex_match(s, p) ? "YES\n" : "NO\n");
	}
	return 0;
}
