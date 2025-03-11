#include <algorithm>
#include <iostream>
#include <string>
#include <vector>
using namespace std;

struct p
{
	string s;
	int d, m, y;
	p(string _s, int _d, int _m, int _y) :s(_s), d(_d), m(_m), y(_y) {}
};

bool cmp(const p& p1, const p& p2)
{
	if (p1.y != p2.y) return p1.y < p2.y;
	if (p1.m != p2.m) return p1.m < p2.m;
	return p1.d < p2.d;                  
}

int main()
{
	int n, d, m, y; cin >> n;
	string s;
	vector<p> v;
	for (int i = 0; i < n; i++)
	{
		cin >> s >> d >> m >> y;
		v.push_back(p(s, d, m, y));
	}
	sort(v.begin(), v.end(), cmp);

	cout << v.back().s << endl << v.front().s;
}
