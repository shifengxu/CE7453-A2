using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurveLib
{
    /**
     * The coefficients are copied from:
     * https://pomax.github.io/bezierinfo/legendre-gauss.html
     */
    public class GaussianQuadratureCoef
    {
        public int n;
        public List<(double x, double weight)> CoList = new List<(double x, double weight)>();

        public GaussianQuadratureCoef(int n)
        {
            this.n = n;
        }

        public void AddWeightAndX(double w, double x)
        {
            this.CoList.Add((x, w));
        }

        public static GaussianQuadratureCoef Get(int n)
        {
            var g = new GaussianQuadratureCoef(n);
            if (n == 2)
            {
                g.AddWeightAndX(1, -0.5773502691896257);
                g.AddWeightAndX(1, 0.5773502691896257);
            }
            else if (n == 3)
            {
                g.AddWeightAndX(0.8888888888888888, 0.0000000000000000);
                g.AddWeightAndX(0.5555555555555556, -0.7745966692414834);
                g.AddWeightAndX(0.5555555555555556, 0.7745966692414834);
            }
            else if (n == 4)
            {
                g.AddWeightAndX(0.6521451548625461, -0.3399810435848563);
                g.AddWeightAndX(0.6521451548625461, 0.3399810435848563);
                g.AddWeightAndX(0.3478548451374538, -0.8611363115940526);
                g.AddWeightAndX(0.3478548451374538, 0.8611363115940526);
            }
            else if (n == 6)
            {
                g.AddWeightAndX(0.3607615730481386, 0.6612093864662645);
                g.AddWeightAndX(0.3607615730481386, -0.6612093864662645);
                g.AddWeightAndX(0.4679139345726910, -0.2386191860831969);
                g.AddWeightAndX(0.4679139345726910, 0.2386191860831969);
                g.AddWeightAndX(0.1713244923791704, -0.9324695142031521);
                g.AddWeightAndX(0.1713244923791704, 0.9324695142031521);
            }
            else if (n == 8)
            {
                g.AddWeightAndX(0.3626837833783620, -0.1834346424956498);
                g.AddWeightAndX(0.3626837833783620, 0.1834346424956498);
                g.AddWeightAndX(0.3137066458778873, -0.5255324099163290);
                g.AddWeightAndX(0.3137066458778873, 0.5255324099163290);
                g.AddWeightAndX(0.2223810344533745, -0.7966664774136267);
                g.AddWeightAndX(0.2223810344533745, 0.7966664774136267);
                g.AddWeightAndX(0.1012285362903763, -0.9602898564975363);
                g.AddWeightAndX(0.1012285362903763, 0.9602898564975363);
            }
            else if (n == 10)
            {
                g.AddWeightAndX(0.2955242247147529, -0.1488743389816312);
                g.AddWeightAndX(0.2955242247147529, 0.1488743389816312);
                g.AddWeightAndX(0.2692667193099963, -0.4333953941292472);
                g.AddWeightAndX(0.2692667193099963, 0.4333953941292472);
                g.AddWeightAndX(0.2190863625159820, -0.6794095682990244);
                g.AddWeightAndX(0.2190863625159820, 0.6794095682990244);
                g.AddWeightAndX(0.1494513491505806, -0.8650633666889845);
                g.AddWeightAndX(0.1494513491505806, 0.8650633666889845);
                g.AddWeightAndX(0.0666713443086881, -0.9739065285171717);
                g.AddWeightAndX(0.0666713443086881, 0.9739065285171717);
            }
            else if (n == 12)
            {
                g.AddWeightAndX(0.2491470458134028, -0.1252334085114689);
                g.AddWeightAndX(0.2491470458134028, 0.1252334085114689);
                g.AddWeightAndX(0.2334925365383548, -0.3678314989981802);
                g.AddWeightAndX(0.2334925365383548, 0.3678314989981802);
                g.AddWeightAndX(0.2031674267230659, -0.5873179542866175);
                g.AddWeightAndX(0.2031674267230659, 0.5873179542866175);
                g.AddWeightAndX(0.1600783285433462, -0.7699026741943047);
                g.AddWeightAndX(0.1600783285433462, 0.7699026741943047);
                g.AddWeightAndX(0.1069393259953184, -0.9041172563704749);
                g.AddWeightAndX(0.1069393259953184, 0.9041172563704749);
                g.AddWeightAndX(0.0471753363865118, -0.9815606342467192);
                g.AddWeightAndX(0.0471753363865118, 0.9815606342467192);
            }
            else if (n == 14)
            {
                g.AddWeightAndX(0.2152638534631578, -0.1080549487073437);
                g.AddWeightAndX(0.2152638534631578, 0.1080549487073437);
                g.AddWeightAndX(0.2051984637212956, -0.3191123689278897);
                g.AddWeightAndX(0.2051984637212956, 0.3191123689278897);
                g.AddWeightAndX(0.1855383974779378, -0.5152486363581541);
                g.AddWeightAndX(0.1855383974779378, 0.5152486363581541);
                g.AddWeightAndX(0.1572031671581935, -0.6872929048116855);
                g.AddWeightAndX(0.1572031671581935, 0.6872929048116855);
                g.AddWeightAndX(0.1215185706879032, -0.8272013150697650);
                g.AddWeightAndX(0.1215185706879032, 0.8272013150697650);
                g.AddWeightAndX(0.0801580871597602, -0.9284348836635735);
                g.AddWeightAndX(0.0801580871597602, 0.9284348836635735);
                g.AddWeightAndX(0.0351194603317519, -0.9862838086968123);
                g.AddWeightAndX(0.0351194603317519, 0.9862838086968123);
            }
            else if (n == 16)
            {
                g.AddWeightAndX(0.1894506104550685, -0.0950125098376374);
                g.AddWeightAndX(0.1894506104550685, 0.0950125098376374);
                g.AddWeightAndX(0.1826034150449236, -0.2816035507792589);
                g.AddWeightAndX(0.1826034150449236, 0.2816035507792589);
                g.AddWeightAndX(0.1691565193950025, -0.4580167776572274);
                g.AddWeightAndX(0.1691565193950025, 0.4580167776572274);
                g.AddWeightAndX(0.1495959888165767, -0.6178762444026438);
                g.AddWeightAndX(0.1495959888165767, 0.6178762444026438);
                g.AddWeightAndX(0.1246289712555339, -0.7554044083550030);
                g.AddWeightAndX(0.1246289712555339, 0.7554044083550030);
                g.AddWeightAndX(0.0951585116824928, -0.8656312023878318);
                g.AddWeightAndX(0.0951585116824928, 0.8656312023878318);
                g.AddWeightAndX(0.0622535239386479, -0.9445750230732326);
                g.AddWeightAndX(0.0622535239386479, 0.9445750230732326);
                g.AddWeightAndX(0.0271524594117541, -0.9894009349916499);
                g.AddWeightAndX(0.0271524594117541, 0.9894009349916499);
            }
            else if (n == 18)
            {
                g.AddWeightAndX(0.1691423829631436, -0.0847750130417353);
                g.AddWeightAndX(0.1691423829631436, 0.0847750130417353);
                g.AddWeightAndX(0.1642764837458327, -0.2518862256915055);
                g.AddWeightAndX(0.1642764837458327, 0.2518862256915055);
                g.AddWeightAndX(0.1546846751262652, -0.4117511614628426);
                g.AddWeightAndX(0.1546846751262652, 0.4117511614628426);
                g.AddWeightAndX(0.1406429146706507, -0.5597708310739475);
                g.AddWeightAndX(0.1406429146706507, 0.5597708310739475);
                g.AddWeightAndX(0.1225552067114785, -0.6916870430603532);
                g.AddWeightAndX(0.1225552067114785, 0.6916870430603532);
                g.AddWeightAndX(0.1009420441062872, -0.8037049589725231);
                g.AddWeightAndX(0.1009420441062872, 0.8037049589725231);
                g.AddWeightAndX(0.0764257302548891, -0.8926024664975557);
                g.AddWeightAndX(0.0764257302548891, 0.8926024664975557);
                g.AddWeightAndX(0.0497145488949698, -0.9558239495713977);
                g.AddWeightAndX(0.0497145488949698, 0.9558239495713977);
                g.AddWeightAndX(0.0216160135264833, -0.9915651684209309);
                g.AddWeightAndX(0.0216160135264833, 0.9915651684209309);
            }
            else if (n == 20)
            {
                g.AddWeightAndX(0.1527533871307258, -0.0765265211334973);
                g.AddWeightAndX(0.1527533871307258, 0.0765265211334973);
                g.AddWeightAndX(0.1491729864726037, -0.2277858511416451);
                g.AddWeightAndX(0.1491729864726037, 0.2277858511416451);
                g.AddWeightAndX(0.1420961093183820, -0.3737060887154195);
                g.AddWeightAndX(0.1420961093183820, 0.3737060887154195);
                g.AddWeightAndX(0.1316886384491766, -0.5108670019508271);
                g.AddWeightAndX(0.1316886384491766, 0.5108670019508271);
                g.AddWeightAndX(0.1181945319615184, -0.6360536807265150);
                g.AddWeightAndX(0.1181945319615184, 0.6360536807265150);
                g.AddWeightAndX(0.1019301198172404, -0.7463319064601508);
                g.AddWeightAndX(0.1019301198172404, 0.7463319064601508);
                g.AddWeightAndX(0.0832767415767048, -0.8391169718222188);
                g.AddWeightAndX(0.0832767415767048, 0.8391169718222188);
                g.AddWeightAndX(0.0626720483341091, -0.9122344282513259);
                g.AddWeightAndX(0.0626720483341091, 0.9122344282513259);
                g.AddWeightAndX(0.0406014298003869, -0.9639719272779138);
                g.AddWeightAndX(0.0406014298003869, 0.9639719272779138);
                g.AddWeightAndX(0.0176140071391521, -0.9931285991850949);
                g.AddWeightAndX(0.0176140071391521, 0.9931285991850949);
            }
            else
            {
                throw new ArgumentException($"Not support n={n} for Gaussian Quadrature");
            }
            g.CoList = g.CoList.OrderBy(o => o.x).ToList();
            return g;
        }
    }
}
