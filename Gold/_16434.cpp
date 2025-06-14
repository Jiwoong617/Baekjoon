#include <iostream>
#include <cmath>
#define ll long long

using namespace std;

int main()
{ 
	ll n, atk, t, a, h, hp = 0, maxhp = 0; cin >> n >> atk;
	while (n--)
	{
		cin >> t >> a >> h;
		
		if (t == 1)
		{
			ll cnt = (h + atk - 1) / atk;
			ll dmg = (cnt - 1) * a;

			if (hp < dmg)
			{
				maxhp += dmg - hp;
				hp = 0;
			}
			else
				hp -= dmg;
		}
		else
		{
			atk += a;
			hp = min(hp + h, maxhp);
		}
	}

	cout << maxhp + 1;
	return 0;
}
