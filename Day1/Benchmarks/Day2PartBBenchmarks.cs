﻿using BenchmarkDotNet.Attributes;
using Day1.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Benchmarks
{
    [MemoryDiagnoser]
    public class Day2PartBBenchmarks
    {
        // 268.0 microseconds.
        // Changed to logical exclusive OR check - 253.7 microseconds.
        [Benchmark(Baseline = true)]
        public void GetCountOfValidPasswords_Benchmark()
        {
            new Day2PartB().GetCountOfValidPasswords(InputList);
        }

        private readonly List<string> InputList = new List<string>
        {
"1-7 q: qqqqxvqrkbqqztlqlzq",
"1-3 q: cqbm",
"15-16 h: hhhhhhhhhhhhhhbsh",
"4-16 x: xvbxswpnvxtnfjrxxx",
"6-7 v: kbbvnswp",
"17-18 h: hhhvhhhhhhhhhhhhhh",
"1-7 w: twftdrb",
"4-5 t: wcjtfpt",
"3-9 f: mbfvfptbfq",
"3-10 x: xfxxxxxxxv",
"5-11 p: ppvhkgpmwfjp",
"5-8 c: cbhhrtsbpf",
"13-14 t: ttttltttgttttvht",
"11-16 m: mmmmmmmrmmdmmmmxmmm",
"3-13 b: bbbbbgbbbbbkkbvd",
"7-10 d: ndddwdmdddhddv",
"4-7 d: gcndnddkwhd",
"14-18 z: zzzzzzzzzzzzzvzzzzzz",
"5-6 c: mfcwccckdccfmzc",
"9-14 p: bppzpwhzdgnpnh",
"11-19 q: jqhqqqqqqqmfqqqqqqqq",
"5-6 h: kqhpgl",
"15-18 w: wwwwwwwwwwwwwwqwwqw",
"2-10 m: qmmmmtphbrw",
"10-20 k: jxlnkxnkhlkgkzhxbdvg",
"8-9 c: ccccccccc",
"12-19 k: vlkkkkklkzkkzkkckkfk",
"13-14 s: bsfssqsscsssdj",
"11-13 p: rmpdppplgcnpwxd",
"9-16 c: ccccccccrclccqcgcc",
"3-8 s: snsssmssdns",
"13-19 t: ttttttttttttttttttwt",
"7-8 q: dqqqdqqqqnqdq",
"10-11 w: wwwvwwvhwtvwwwmw",
"3-6 b: bbsnbpbckbb",
"1-4 g: gggjg",
"6-8 b: jvrqbbmb",
"2-6 t: cvdtzn",
"3-4 v: vvmd",
"2-8 z: vmwhtskz",
"2-6 b: jbrbjbs",
"1-2 d: ndzwd",
"17-20 r: xjfmlrrjcnnrmkvhrpwr",
"8-10 q: qqqwqqqqqdl",
"2-5 p: phppxpppppppp",
"9-10 z: zzzzzznzzz",
"8-9 k: phgksffkrfgp",
"11-13 w: wwwwwwwwwwnwz",
"9-11 k: krkkkkqkkkkskkk",
"19-20 d: dmcwfddgdddvdffdhdld",
"8-11 f: bflfqsffvfdffmfpfqf",
"6-10 v: wwqvvvjvrd",
"4-5 v: vvdvw",
"3-4 h: hdhh",
"9-10 d: dndfdddddd",
"3-13 n: nnfnnnnnnnnnnnnnnmnn",
"5-12 b: zwqcbkfcbbnbb",
"5-15 q: qqrdqqqmqqnqqnjkqqqw",
"6-8 l: vfllklxllclll",
"3-4 h: hchh",
"12-16 b: bbbbbbbbbbbhwbbtgbs",
"4-10 p: ppwxplpppp",
"4-5 s: szhss",
"8-10 w: tvdtvbwnlfvkspxp",
"4-9 z: zzznnkzwdzrz",
"5-14 p: pppppppppppjpp",
"6-7 n: hnnnnqnn",
"1-4 q: qqdqqq",
"7-8 w: wwwwwwbpww",
"3-10 x: xfxxnxjxxxpx",
"5-19 m: kmqhgpjdszvgrfrdlhm",
"10-12 k: kqqzkkkkkkkk",
"4-7 l: llpqcgmll",
"4-5 p: rwppp",
"2-6 q: mqqhrsdk",
"7-10 m: cmmvscmmkm",
"9-18 k: kkkkkzkkqdpkdlkjpgk",
"2-7 m: xmglcvmkmln",
"8-12 n: nnnnnnnfjnnbn",
"4-5 n: nnnnn",
"13-17 z: zzzzzzzzzzzzkzzzz",
"1-5 t: mfftmn",
"2-3 n: nskh",
"11-18 s: sjssgsssfstzsbhnsw",
"14-16 d: pgxrmlxdthpdndfdt",
"2-3 h: hhhhh",
"3-4 s: hssn",
"7-9 f: fffffcmff",
"2-4 s: srwbvhnlqssdpsssx",
"3-4 v: vvvvvsvxvvh",
"12-13 x: xxxxsxsxxdxmpjxlxxf",
"15-16 m: cjcmmmmgdmbnmcmm",
"8-11 l: hsjlnlvlfchgjlrdl",
"9-11 k: kkknkkdkdkkk",
"5-6 q: qgqqfpq",
"16-19 w: wwwwfwwwwwwwvlwwwtw",
"2-13 n: nnnjngnwgldsnrnrr",
"5-6 x: qwbpxx",
"4-5 x: xxxhx",
"11-13 t: ctpskdtbwbtkstfj",
"2-8 z: jwznsgln",
"17-18 r: rrrrrrrrrrrrrrrrwnr",
"7-12 v: bkpvwzzsdnsd",
"5-7 h: hxxnpzh",
"7-8 z: zzzzzzxs",
"3-7 z: hzstpkrlht",
"7-10 p: ppgkppnpdppj",
"10-11 g: gghhgvgggwf",
"9-11 q: qqqqxqqqqpqqqq",
"2-3 r: qrrfr",
"3-8 x: xvxzsxtxgxb",
"11-14 q: fbqtzvjdqqhqqrqjrqq",
"11-16 c: cccpccccccscwccfccn",
"9-11 m: snmmmcmmsmmmmkm",
"2-11 m: mmmczqsmclmrvmbzlv",
"10-15 z: zzzzzzzzzjzzzzkjzzm",
"3-13 j: jjxjjjjwjjjjbjjjdjjd",
"7-10 j: sjjqjjvzjjcjrh",
"8-9 x: xxxxxxxzxxx",
"4-11 n: nnmnmndfnhqnhnn",
"16-19 v: kntvxvvvvpvvvvghkzp",
"6-9 b: pbbbxxjfqvngbvbb",
"16-17 j: jjjjjjjjmjjjjjjjjj",
"2-3 t: wttttttt",
"10-15 c: cccccccccgpcccccc",
"7-10 j: jjjjjjqjjrj",
"1-7 f: cffffftfff",
"8-14 r: rrnrrrrrfrrgscrmr",
"1-12 b: jbbbjbkwbgbb",
"13-16 m: mmxmmmmmwmmwmfmmmhbm",
"1-9 s: fsssssssqs",
"8-15 q: pxqqqqvbqqsbqzjngkv",
"3-4 w: wkspxwm",
"1-7 h: gkfhhhjhhhch",
"1-4 w: sqrnwwgwqdw",
"2-6 d: dpdwdld",
"2-3 m: mmmmm",
"4-6 p: pppspp",
"2-7 c: ctcglxx",
"11-13 x: xxqxxxxxxxxxxd",
"7-9 c: cgccccbcrc",
"6-9 p: xspppkppprp",
"4-5 v: vvfqrv",
"15-19 l: llwllllllfllllglllcl",
"10-17 v: vvvvvvvvvgvvvvvvk",
"11-14 s: sstngtbhsfsgds",
"3-4 c: dxklc",
"6-7 l: lllllll",
"8-10 w: wwwwwwxtwkwnw",
"3-4 l: sgllkmdpzgzvllzv",
"7-17 w: zdfsdmwbphwhzwrxww",
"2-12 l: rbwfpnmzgtsl",
"3-6 s: qssdwlfbnm",
"5-16 f: fffffffffffffffzff",
"12-14 l: lllfllllldlllljll",
"14-19 x: pxxxxxxxqxxxxxxxkxwx",
"12-14 b: bbbbbbbbbbbrbnbbbb",
"2-12 j: trjqljjgrjjq",
"1-10 q: qqqqqqqqqqqqq",
"1-6 t: jttttrtt",
"1-2 v: rpvfcxhcgx",
"4-5 r: frsrr",
"1-6 v: jvvvvqvvvv",
"2-4 v: tvvb",
"4-5 h: hhchhzhqhcvh",
"8-9 c: ccphccccccc",
"13-15 c: cccbccccccxccxclcscc",
"5-6 b: bbkbpczbs",
"10-16 g: gdgggggggggggggggg",
"1-11 f: fmffxfffgcfwfffbzff",
"3-13 m: mzmmkmntbmmmmcz",
"1-2 g: xkgq",
"10-12 r: rbrmrrrrrwrrhrqvkr",
"7-8 m: wbbmmmmmfmm",
"3-4 l: dsnt",
"4-5 k: kkkkkkk",
"16-17 r: rrrrcrgrrmqwjrpwmtr",
"15-17 z: zzzzzzzzzzzzzzzzzzz",
"13-15 b: zbbbbbbbbbbttbbb",
"8-13 w: twrwwwlwtwwww",
"10-11 w: wwwwwwwwwwwwwwwwww",
"4-6 b: pxvqbb",
"5-8 n: wnnnznngw",
"4-9 q: njjqqkrlq",
"10-15 c: cckhfccdhfccccj",
"10-15 c: ccrktcccgccgccz",
"1-5 s: dvssx",
"2-3 w: wwnw",
"3-4 n: nnnnc",
"7-16 n: tdlhmgsqknfnwgnnwmn",
"9-11 z: zgdzzzzwfgjwzzzm",
"4-5 f: ffpffff",
"3-6 f: fvgfcff",
"5-6 f: fkffhhlhrfg",
"7-13 g: gtflglggggwbg",
"4-5 w: wwdwrw",
"8-10 w: hwpzzwwwjbqfww",
"5-11 f: ftgfffffffpqffffffff",
"6-7 f: fffffml",
"6-12 j: jjtjjtjjjzjzjh",
"4-6 h: phwtrn",
"10-14 l: lllllllllcllll",
"6-7 d: hdwxdsk",
"13-18 w: kwwwwwwwwwwwwwwjwww",
"3-8 q: bpqtzmqqljll",
"1-3 c: cccds",
"4-5 m: mmmmzd",
"4-7 c: cccjcck",
"4-6 t: ctdvts",
"3-10 x: xsxrxshzjxrt",
"3-6 j: wljvmxqzrjhctx",
"4-5 v: vwvvcld",
"8-9 l: blllllvllglllll",
"4-14 j: jjjjjjjxxsjmjjjjj",
"8-12 v: bvvvvvvqvvvbvv",
"2-6 g: pgsgcglt",
"1-4 g: qggs",
"7-9 h: phchhpxhqhhh",
"5-7 z: czzjzrnq",
"3-4 k: kkkw",
"2-3 v: vjfv",
"7-11 v: slrrxhrhnvvk",
"7-10 t: czhvlfwthc",
"2-17 m: zmmmmtbmzlwmmmmslbm",
"1-4 m: fmjz",
"6-8 d: sdddddddddw",
"2-5 h: pnfkhrwchvc",
"2-4 r: brsrktfkqdlhzvvsfhf",
"3-4 n: qnknnn",
"7-10 f: rvnzfmfzrfdqkffc",
"2-5 x: hxxqxkxxw",
"1-7 w: wwqzwkww",
"2-3 s: ssps",
"8-16 d: ddjdddddddddbddddd",
"10-12 d: dddxddddwldfsd",
"1-6 v: skcvcwjf",
"2-7 g: ggggzlggjgwg",
"2-5 j: rjzfjqjzjtjkfp",
"15-17 f: bqslszncqcvrpfrff",
"2-13 d: xcddddddddwdzdmddzd",
"1-9 l: lllmllxlljlxhll",
"10-17 p: msbwpcprpppnsbpppzk",
"2-13 v: vwdvvrsjrvvvpcvvv",
"5-9 c: xscgtfxjbchcp",
"4-6 g: jghgfg",
"7-8 v: vvvvnvvv",
"10-12 z: zzzzzmzzhbxz",
"11-17 b: fknnqwzpgbbqnxkckj",
"1-3 h: zgbpdwdnmmhbnqxm",
"4-6 t: httsznfnx",
"5-10 f: fflfffrfvxvgdq",
"1-3 r: zrrrrrrrrnrr",
"5-7 k: kkkkkkkkkkk",
"6-7 r: rrrrrfgrrrz",
"3-12 s: sssssssssssssss",
"3-5 t: ttjdtt",
"3-4 s: zzhslfrtwsj",
"5-6 d: dddpddv",
"1-7 q: bqqqdqpqq",
"10-13 s: ssstscpsslsrsssds",
"7-8 r: lrrrrrrr",
"5-10 z: jzfwzlzjlz",
"3-8 g: grpggggg",
"1-7 c: jccccjvcc",
"12-13 n: nnnnnnnnnnnhn",
"1-5 t: ztwwnt",
"8-9 z: zszzzzzbzzzz",
"1-5 p: pppppp",
"8-9 j: jjjjjbjkcjgj",
"5-6 x: xwhxlx",
"5-8 d: ddddwddx",
"5-17 l: lllztxdllwblllllv",
"9-18 m: mmgmmzmrmzchvrhqmm",
"17-18 c: wzsjwnccrgbcwhrmgc",
"10-17 f: fbdmffffchfcfkfft",
"17-18 r: rzbzrszcnnrmlrrrzk",
"1-9 p: cppppppppppp",
"1-9 t: ttptqthtttct",
"5-7 c: ncwnhmswscrqgtjtdgcr",
"5-10 f: dffsfffpffhzf",
"8-19 n: mnscfmjnnlvznnvlktn",
"7-8 z: zzzzxzzd",
"8-18 z: lzzbzbczzhdkzzwzgzz",
"1-9 x: rxxsxxxxxxxfxxxx",
"5-10 w: kjrwwptbww",
"12-13 z: zzzfzzzrzzzzz",
"5-6 g: gghggg",
"16-18 q: qqqqqqqqqqqlqqqqqxqq",
"5-9 c: lmcsxccccqjhmtcq",
"1-3 x: xxtnxfqzxxx",
"13-15 w: wddxxwwgqwwxwwww",
"12-16 r: mrrjmrrrhrrrrrrrrr",
"18-19 j: nmfjvcjljptwjnjjjjj",
"1-13 g: ggggggggggggggg",
"11-15 p: tpldppcbbbpzpvppw",
"2-11 x: hbxdxxgnqxbxxxxjjxx",
"9-11 s: nsnsksshzsqss",
"1-16 k: knkkfkkqkhhbkppvkk",
"2-4 x: tlwd",
"5-7 h: npmhclh",
"15-17 t: ttttttttttttttsttt",
"5-6 d: dxddrkddhdl",
"8-12 d: bddjdffdddtkgdhddd",
"7-8 z: dkxzgbzzlw",
"3-4 z: pzzz",
"5-6 t: ttttqvv",
"2-7 d: tpsdkqds",
"18-19 c: cccccccccccccccccbcc",
"2-3 c: hcmj",
"5-6 l: llllwl",
"2-6 t: tqtttx",
"11-12 r: rrrfrrrvrrrcrrrrrrr",
"9-12 s: dspssssshssssss",
"1-3 d: ddddc",
"4-5 t: tbpttzvtqr",
"4-6 j: jjgjdjj",
"2-4 t: tbtb",
"4-5 w: wbwbwwvww",
"10-11 s: dwsspssssssss",
"1-8 s: tssssssl",
"6-8 k: kksgmgkq",
"6-11 p: pppppppjcpq",
"7-8 c: ggcccpcclr",
"13-14 h: hhhhhhhhhhhhbfh",
"14-15 n: hsnnnnnnnnbnnwmnnn",
"11-13 k: xxmqpkkcqkkjn",
"12-14 w: qwkwwwxqwwzwcw",
"1-17 n: nnnnnfnnvnnnnnnrpnn",
"2-3 b: xbsgcgnrh",
"4-5 v: ckpfvkvvswdnh",
"6-7 q: qqqfqqf",
"8-10 m: vntcbkgmmm",
"9-13 m: bvxrzxbmlnmxcvmrwrc",
"4-5 j: fjjlj",
"1-3 k: lkskjkkc",
"8-14 d: ftbhrdxmmfdbkwrsqr",
"1-6 q: qrwcqqmtsqqhq",
"16-17 h: zlmjqfbxhhhfmpvsdg",
"3-8 v: bpwnbflvsljdzfkdmv",
"8-18 m: mskwllxmbgbrdjmhwmn",
"9-10 h: hhhhhzhhhq",
"6-8 t: jttttztv",
"2-4 m: xmmm",
"15-17 f: ffffffffffffffjfwfff",
"3-5 q: xrqqq",
"1-4 h: hhqfmhhh",
"14-15 f: ffffffffffhfcffd",
"2-11 w: fjjnmtswwwbhwcrgjwgd",
"4-9 q: qqqqqhqxqqxqt",
"8-11 g: gggggggcggggggggg",
"1-5 s: dbstvs",
"2-4 z: zzzgz",
"10-13 r: rrrrrrrrrrrrr",
"3-4 r: wrzr",
"5-9 c: cccddcrfccc",
"2-8 k: vkkvlgvvsqzzkkvnk",
"8-9 d: djdxdddwxdqrd",
"5-7 j: cjjpjggqhjwtth",
"5-15 n: nmnbnmnrxnrkznnvnn",
"3-13 j: cjjjjvgjqdjjdqjr",
"6-7 r: rzkrrvr",
"3-5 v: nvczvzgrnk",
"6-7 x: xxxxxdv",
"2-5 c: hccpcw",
"9-16 d: ddddddddddddddddd",
"6-9 c: ccfccdpcqccccp",
"4-5 q: kqtqq",
"1-2 z: zzzk",
"9-13 d: ddddddddddddd",
"5-8 q: prfjgqvzqbqqqq",
"2-6 h: rhrvghkfx",
"3-10 d: rddszpfmrdfgqt",
"7-11 w: wwvwwwkwwwlwwwwwww",
"7-9 b: bbbbbbbbm",
"1-2 r: ffnppzhtrkj",
"1-10 m: mxnmfmlkwmwpkj",
"3-10 n: nnwmnxnxnnl",
"14-16 p: pppppppppppppfppp",
"1-2 m: mmgn",
"11-12 p: hpppppkpppppp",
"6-14 l: lfvlllscxnlpll",
"11-12 r: rrrbrdrrrrrm",
"3-6 w: wwwcgw",
"9-12 b: rbfhbqblnbbbbdb",
"5-6 m: hmmkmmqmkm",
"4-6 q: qclhqjqq",
"4-16 l: lllnpllllllllllblllr",
"4-5 m: nxcmmtmr",
"3-5 q: qmblr",
"4-5 m: mmmmm",
"16-17 b: bbbbbbbbbbbbbbbcbb",
"1-7 p: tjppppppppp",
"5-6 k: kkkksf",
"2-10 x: cxjbfjkwjxqwzjxcbq",
"2-5 t: tsjkfn",
"4-7 g: xgbcrst",
"4-5 x: xxxxxx",
"2-5 s: sszxb",
"4-12 k: wcrkhkgkzklkqkh",
"8-10 b: bbbbbbbnbn",
"2-7 k: fkzfkkkkkklk",
"4-8 w: wwwwwwwww",
"4-8 h: hhhhhhhjh",
"4-11 h: tgbhnnrzpshbjhq",
"6-7 b: bsbdqbbb",
"2-6 t: sqvtbgttbftt",
"2-7 c: mctjgnn",
"3-8 m: ktthpgrfmrqkcj",
"5-7 x: whcxpgxvfq",
"5-14 w: wwwwwwwwwwwwwww",
"2-14 m: nmbxjbsmfjhdxmswks",
"7-11 b: jbbprkhndbqclbb",
"5-7 f: ffbfhfq",
"6-10 z: zzzzzzzzzzzz",
"4-7 d: mkdddgdhdh",
"2-4 d: pkjd",
"5-7 c: ccctqptcccccc",
"15-16 h: hshfjthnhssrvdhb",
"4-5 b: bbbxb",
"5-12 l: llllmllllllnl",
"3-4 t: tbgt",
"5-9 w: wwvzwblwgwwwwvwww",
"3-4 g: mmggfggg",
"8-14 j: jnjjvjcjtmpjtjjxcpw",
"8-9 h: hhhhwhhpch",
"5-7 v: vvdzhcvv",
"16-17 v: vvvvvvvvvvvvvvvtq",
"12-18 s: sdcvjsfqtgnhcsmmsm",
"6-13 n: hnqglmrjfgdnnpvtjr",
"12-13 q: qmqqvqqqtqqvqqq",
"1-9 z: nzzzzzzzzzzzzzz",
"1-4 l: lllllll",
"15-17 j: jjjjjjjjjjqjjjpjhj",
"2-3 t: bttb",
"3-4 q: qqqx",
"1-3 t: wtjt",
"18-19 x: xgnmxxljxwxxztxjvxx",
"2-4 n: pkpf",
"17-19 s: sssvssssssssssssssss",
"13-14 l: llqlllllllllll",
"5-9 m: mxgnmmrdmzll",
"3-5 m: mmcmmmmwmmm",
"4-8 b: bbbbbmplb",
"4-6 x: xxxxvx",
"1-2 m: lvfb",
"9-10 n: npnnnnnpnnnn",
"3-5 m: mmnmwmmmm",
"15-20 r: mwrrrrrrrwrrrrrrnrrr",
"1-2 l: rzlll",
"9-11 s: sssdssnssts",
"3-5 c: lccncc",
"13-14 v: vvvvvvvvvvvvvv",
"2-12 g: vshnfnhkzgjgkqn",
"6-9 k: kqskrckkwg",
"18-19 v: xzwbgvvnwlprqdxvshl",
"16-17 v: vvvvvvvvvvvvvvvzv",
"6-13 m: vkmmclmmwjfcvnmmm",
"5-11 j: sjjjqwjjrjjqj",
"5-7 q: djqhqcqhlz",
"8-9 f: fffmcfftw",
"12-14 x: xqpnjxjxlpxwxxb",
"7-16 h: hhhglhnhbcxhvhhxhh",
"12-13 v: vcvxvvvvvvvvvvv",
"12-13 g: ggdngtlxwlrtsgcgmtgm",
"5-6 n: nhnnhcn",
"3-4 n: nnngwk",
"9-10 k: kkkkkkpkkk",
"6-11 r: rrrrrkrrmrtr",
"3-9 d: dwdwdddqnfdddddddd",
"8-15 q: qvqqxqqwqrqqqfjq",
"6-7 f: ffffflf",
"4-9 m: rpmsmphdmmbpdmmhmpr",
"3-9 q: qqqqqqqqcq",
"3-4 d: hddds",
"2-4 f: rcfj",
"3-4 k: kkhn",
"6-9 n: npnnnnnlj",
"1-6 k: tvspqddqktkkqkvk",
"11-12 x: slxrptmpfqtp",
"12-14 l: jjvwhlldtlllllh",
"13-14 g: ngggggggggggks",
"14-15 z: zzzzzzzzzzzzzjvzz",
"5-6 l: vbsnvllnhlchblllc",
"7-13 z: zgczzbzgzlpnczzz",
"17-18 v: vvvvvvvvrvvvvvvvvvv",
"15-16 h: hhhhhhhhhghhhhhh",
"1-5 n: snnqv",
"6-7 m: mmmmmmmm",
"15-17 p: pppppppppppspqpppxp",
"12-14 w: wwwwwhwwwwwwwwwww",
"4-8 s: fssltbzbsrn",
"5-7 g: gkxgbggg",
"15-16 s: ssssssssssssssss",
"2-4 l: lxtswwg",
"5-6 p: plppzkpp",
"9-10 r: srrrprgrhrrrvrr",
"1-2 d: ddlhchdfll",
"3-4 j: jjwg",
"7-11 b: bkfbvbdvzlbz",
"7-13 q: qgvwkzkrkvvks",
"2-7 c: ccjtcbccccgv",
"2-3 q: fqqq",
"3-4 b: btssh",
"6-7 m: mnmmmmm",
"3-4 n: nrnn",
"5-14 n: fcsxngnnkqxnjnn",
"14-19 x: rmxcxxxxwxzxxhxxxlc",
"3-13 q: qqqqqgqmdshrqnqlqlqt",
"14-16 v: vvpvvvvvjvvnvvvvvvvv",
"15-16 c: cccccccccclcccch",
"4-6 v: hvvcvv",
"7-9 d: dcdmddxdld",
"16-18 x: rxxxxxxxzxxxxxxxdx",
"11-14 l: llcsqllgvfmhlvtvb",
"7-10 h: hhhhhdmhhwhhhh",
"5-17 g: ggggggggggggggggg",
"4-6 q: fbsnmzqdsqsqfpdr",
"12-16 n: fnnlvnflmcnndtfnlw",
"8-13 c: cpwshcvbccbjmlch",
"7-9 l: sfhcltwlc",
"9-13 w: xwwwwxwwwwwgwwkw",
"5-6 q: kqqqqqjqqqqqqk",
"14-17 k: kkkkkkkkcvbkkqxtkkkk",
"8-9 h: qjhxhjhzl",
"3-6 l: jlllvl",
"10-11 q: shkxnqwfrhhznlb",
"3-9 l: dwbvfgngtzcbhzlft",
"16-20 b: qstrwcrclxzbwtlbpnwb",
"8-10 n: ndhpptnnnjnnnbnn",
"4-8 l: lllnlllw",
"1-3 v: vdfxksvvn",
"14-17 b: blbbmbbbbbbbbbxbbbb",
"9-10 t: tttrkltgfbtth",
"10-12 n: njhnnnznnnnn",
"8-9 w: hfwwdwwww",
"4-5 c: scrcccwc",
"17-18 t: ttttttttttttttttmp",
"10-11 t: tttttttttvjtttttt",
"1-3 m: mdlrc",
"8-9 r: zrnjxkbrrppzgvf",
"3-4 d: sqddksgdjmd",
"3-5 m: mmmmmmm",
"1-8 h: nhclfdhlqwhhczn",
"2-7 c: bbcbccgxhcwn",
"4-6 l: zldqlgl",
"9-11 n: pqbxnxfzhtd",
"2-15 r: drmrjfxlqvmlcnwlbn",
"14-15 k: kkkskkkkkkkkktk",
"4-5 x: mxxzsxxxxx",
"1-2 p: hhfwz",
"6-13 b: mbdbkbpbjbbcb",
"12-16 t: tthfzkrqvhltzhlttwtw",
"6-11 h: hhhhhhhhhchzh",
"3-8 q: knndgrkmnqqxjj",
"5-7 v: svkvhfvv",
"6-9 r: rrrrrwrrrrr",
"3-10 p: pspxqhpxfqp",
"3-9 z: xfzzmjgqzgjzczqpnj",
"6-10 n: nnnncrnnnqnnnnn",
"1-7 k: kkkkkkkkk",
"2-4 m: mhmj",
"3-7 j: qjtjjmbjjkfjjrj",
"2-7 r: nrdxvnr",
"1-2 l: wrrr",
"3-4 t: ttjktt",
"9-13 l: lllllllclslllll",
"12-19 p: cpplpppphpppppdpntp",
"10-12 p: dnpppppppwpgpppp",
"2-4 z: pzzb",
"1-2 k: kpkt",
"4-7 r: rrrrrrq",
"1-7 t: xttwtnqttd",
"1-4 g: zngs",
"4-6 d: qszrkcxxdt",
"1-6 b: cpbhfm",
"3-4 m: knmn",
"9-11 c: lpdbchcckwnrc",
"3-4 r: rrrrr",
"12-18 q: qzqqwqqqqxrqqwqqqdqq",
"6-9 v: wvvvvpvbq",
"6-7 g: sggxxdhl",
"12-17 b: mbsgqwvzlnjskhxctt",
"4-5 f: rsfkc",
"9-12 h: hhhhhhhhshhhhhh",
"4-5 p: nppcn",
"3-5 g: ggwsmggsgggfg",
"4-6 p: gppfpsh",
"13-14 v: fvftvjtqvxsqhzrv",
"2-3 l: jlmbl",
"2-4 v: wwjvv",
"4-8 l: lllhlhllmlplg",
"1-14 f: znvtwnmslnfhjrds",
"3-10 z: zzhzkhzzlkdxzzz",
"17-19 r: rrrrrrrrrrrrrrrrrrrr",
"15-16 q: qpvqdgqkqqqqqqqq",
"5-12 k: wkkkkknkszpkkrk",
"3-8 j: jjhjjjjwj",
"2-12 s: qvknfbrpsrfsp",
"11-12 j: jjjjjjlfjjcrzjtj",
"3-13 m: mmmmglpmhtrfvmfmmmx",
"6-17 l: lllllblllllllllldll",
"4-5 q: rqqnqqqqq",
"8-9 p: fppppnspp",
"11-17 q: pqqqqqqqqqjqlqqqqd",
"3-4 l: lslll",
"1-10 r: bgrrrrrrrprrr",
"12-17 g: gggwjnxgmggngggrgpg",
"14-16 z: zxzzzzzzzzzzzpzgz",
"4-12 t: sttttttttttttwtz",
"6-7 x: xlzxxxxg",
"3-4 g: ggcg",
"3-11 c: zblkwrxvcnl",
"3-16 l: lhlljbljsllfhlklrlv",
"8-9 v: vvvvvvvvtp",
"2-5 f: fpbqcglx",
"3-15 g: cwmgbgntbgwccqggpv",
"4-11 m: mwwfhdgxdsmxckqcqvpg",
"12-14 v: vvpvvvvvvvvfnwvv",
"2-4 b: bbsxbwqbbx",
"4-7 s: knsnxlsmg",
"3-4 z: zzzzz",
"1-4 x: mxxxxxxx",
"2-7 w: pxwmtbkskmmfcddczqd",
"9-12 b: bbbbbqlbgbbb",
"3-4 l: mlqrlchqn",
"2-3 b: bbbb",
"13-15 x: lxxfjvqxhxhlxxx",
"5-8 m: mtmnkvmcm",
"3-7 v: xvwvvvwbtvs",
"2-16 x: wsbhsvzxbjfjwlzlzr",
"3-4 d: dzrd",
"5-7 l: llllllml",
"14-15 d: dddddddddddddwb",
"6-7 t: ttttfbttg",
"11-12 v: vvvvvvvvvvvvvvvv",
"11-14 z: zzzzzlzzzzdfvjtzk",
"4-20 b: jfnnqxxvxwhbfmbxqdxq",
"6-9 d: dddddzdddd",
"1-2 s: rnwsscss",
"2-3 q: kqkrhq",
"8-16 r: krlrxhrchrrrrvrkr",
"5-7 r: svcrrfq",
"2-13 b: bbbbbbbbbbbbbbs",
"3-7 k: pdxkstw",
"9-16 w: wwwwwwwwvwwwgwwww",
"3-5 g: gbgkggpcmjgrc",
"13-15 d: dddmdddmdddmldg",
"3-17 t: tkpttktttbttttttt",
"1-5 n: pnnngnnn",
"3-4 f: ffhf",
"3-7 p: tqpnncpczlp",
"4-13 b: ppbnsfztshmbbggn",
"1-4 r: rvlrrqrrrt",
"4-8 s: snfwsssrsrrssssszp",
"1-7 w: fwwwwwww",
"1-4 d: fdjb",
"7-8 l: llglthmjvlllt",
"7-8 w: wwwwwwzjw",
"7-9 v: zrgvvvvvvv",
"2-7 d: pdddzvh",
"2-9 w: nwwwbjswwxwxczlmh",
"5-10 w: wwcwwwwfwwghwbw",
"6-8 n: dqgnqjnnnnn",
"4-14 r: rdrfrrrrrrrrrvrrr",
"10-11 d: ddddddghtdfdhd",
"2-6 n: gngqzn",
"6-7 f: ffffdff",
"5-9 b: bbbbwbbbzb",
"7-9 n: knnnngnfnnn",
"8-14 b: gbnbsdbwcwdbvb",
"6-9 w: nttwjwbmw",
"3-13 c: gswwmvqdchfcgfrqcn",
"11-12 k: kzkvhkfrjxxjv",
"3-9 d: xdzkdgfdrx",
"6-13 q: qqqqcqqqqqqqqqq",
"7-9 b: bmbbbbbbb",
"8-16 p: hppgwpbmppcppppd",
"9-12 m: mwmmscmmdmpkmmm",
"3-6 n: nnnnnnn",
"3-16 f: lfqfhfffdfffszfkh",
"12-13 f: ffffffffffffmftffxf",
"1-5 k: kkkqk",
"3-6 f: ffsgft",
"2-9 z: ktzvzztzzrzzfnk",
"4-7 p: pppppgp",
"5-9 j: jgtjkvjhtjmvtc",
"4-5 g: ngngw",
"5-6 f: ffffcgf",
"3-11 k: xkkkcvwkkck",
"7-11 c: qcccpchcccc",
"3-17 h: hhnhhhhhhhhhhhhhhh",
"4-5 x: bxjxj",
"18-19 v: vbvcvvvcwvvvvvvvvtn",
"12-14 d: dddddddddddwdxddd",
"6-10 b: bbbbbbbbbbbb",
"1-4 f: pfjf",
"1-8 b: bbbbbbltbbbbbb",
"14-15 d: dzddkfqcdxwfdnd",
"8-10 t: tvxwlxltjt",
"7-9 l: lxklrwlhl",
"3-6 c: cclccdc",
"15-17 w: wdwwwwwwwwxwwwqwfw",
"1-4 h: ngkhh",
"3-4 j: jjjj",
"4-9 h: nphhzhhmhgb",
"5-10 v: tsxzvvdvmvvsvp",
"1-11 r: frjgrqrrrrkrrmrl",
"10-12 p: zlkppppppmxppphsgd",
"5-8 p: stmggpsmx",
"3-5 r: rrrrrrrrrrrrrr",
"2-3 t: ttgt",
"6-11 m: mmjmsmhmmsmdmfmvm",
"6-8 s: pnkbhsfsfgsr",
"7-13 t: gchcvtttwgkmlbw",
"8-11 l: lllllllrllrlh",
"5-7 d: djvddzdd",
"3-4 z: zzzzkk",
"5-11 s: wsbdskxssjtqcs",
"2-3 w: wwwszj",
"1-4 m: mmvm",
"3-9 x: bkzkrvkjfbtxn",
"5-6 z: zzzzzwz",
"1-4 v: vvvrvv",
"1-4 d: zdxd",
"6-8 k: klfnzkrswq",
"1-6 p: pkjpcpntjzvp",
"14-16 p: pdpppqmpmppqppppgp",
"9-10 w: wwvglrwkrbwwwkwzww",
"3-6 v: vfdvvcsvv",
"9-13 z: zzzzzzbzzgfzzzzzczz",
"4-5 n: nnnqnn",
"4-13 m: jmbmmmmmmmnmmmvmm",
"2-10 r: rlrcrrdnkrkrsqr",
"9-14 r: rzrgrrrrhrrbrsrr",
"9-11 f: ffpffzfvffzf",
"10-11 j: jzjjjjzfpjjjrsgjjt",
"3-4 b: bbbnbb",
"4-6 z: zgzwzqhq",
"10-11 j: jjxjxhjjjwj",
"4-5 b: bbbbb",
"4-5 d: dbzhw",
"2-8 r: rrrlrrrrgrgfrwdf",
"1-5 q: qmtrq",
"9-13 j: jkjjjjjjjzjjt",
"3-7 j: rjjjjjjjm",
"5-9 z: zzzzdzzznzz",
"2-13 t: tjtttttttfttsttt",
"12-13 d: kbddmmkmcwdkddw",
"3-4 q: qqql",
"5-6 j: jjjjsqjj",
"1-2 b: bbgwqt",
"3-11 t: tftjtttttttttt",
"9-12 h: hjxhhhhhqhhzz",
"1-2 m: ncmmmml",
"1-3 x: qxxs",
"1-7 t: dtstrnxttt",
"11-13 q: qqdqqpjjqktqbqnqqq",
"2-5 p: pppppp",
"2-4 n: njdjzpnghzbgvnngqn",
"11-12 g: lpfwcvsqgmggfrjmdvs",
"1-7 n: hrwhnvrmm",
"12-13 s: hssdssscsgsksjssss",
"3-8 x: csxgdxkxxptmlw",
"9-11 q: qqqqqqnqkqmqqqqq",
"3-4 g: wzkf",
"7-8 t: cktttttt",
"4-12 c: fgdjrccpmhcccwcgfm",
"6-8 p: jppppppt",
"1-4 p: pppppr",
"1-7 n: nnrrrtndwn",
"1-6 l: rldlkq",
"2-4 x: rglr",
"2-7 p: vpvmkgp",
"4-5 n: nnnnz",
"5-18 w: txgfflhvtdpdvwlwmmq",
"9-10 l: tlllllllddl",
"1-3 b: xpzbbbrbbr",
"3-5 n: npnpnn",
"10-14 q: nqqqqqqqqqqqqqqdqx",
"7-10 w: bdwwwwgwljxgv",
"7-11 k: kwknkkdlzkk",
"1-10 w: wsjbvzwslmwttq",
"15-18 b: bbbbbbbcbbbrbbbbbbb",
"6-8 j: jdjjnlfj",
"10-11 r: xrgrrrrrnvwrrfrr",
"11-15 x: xxxxxxxxxxxxxxjx",
"5-10 w: wfwwnwvngwlwwlw",
"2-4 k: kkkk",
"3-5 h: hjhhh",
"7-8 s: lqsssscjrss",
"10-12 t: tttsttttttttg",
"3-8 p: szpsqzqp",
"3-8 x: xxxxxxxxx",
"6-7 r: rrxrrdrr",
"1-2 b: zbbbbbbbbbbbbb",
"3-6 v: vxvkvv",
"4-5 w: wwwwwwdw",
"3-5 n: nnfnn",
"11-12 g: gggggggvggxgg",
"10-12 s: sssqssssssssns",
"3-7 h: hlmhhhhhhh",
"7-8 v: vsdcvkvvszzm",
"6-9 g: ggwnldgws",
"14-15 q: qqqqkqqqqqqqkwkq",
"8-9 l: bttjllqhnqjdvhsnk",
"10-11 s: sqsscsqsscts",
"10-14 h: hjhxhhhnhhxglkhvzl",
"3-6 r: krrnvr",
"12-17 z: zzsfzzzjzzzrzhzzgh",
"1-5 b: bdnmb",
"18-19 c: cccccccccccccccccckc",
"13-16 t: tttttttrtttcdttpt",
"5-6 c: ccczlxc",
"2-7 b: phbqtkkkdglk",
"4-6 x: tgrmqlxwgrgwxmkfr",
"2-7 p: xspljfg",
"4-9 b: bbbwbbbbmbbb",
"3-9 b: brbvbbxqb",
"13-14 c: cccpckqscbcchc",
"1-3 m: mmmm",
"1-2 v: bvvvvc",
"2-3 b: bbsbbbnbbb",
"1-2 f: gkfms",
"5-6 n: nnnnnq",
"4-5 c: kffccnrmn",
"1-6 b: slgwbm",
"2-3 x: mxcj",
"3-4 p: gpbqpfsp",
"5-8 s: szwszsss",
"5-6 g: zkgjggg",
"3-10 v: twmqbvvnvv",
"3-5 z: shlzs",
"1-6 r: wrrljrfntswb",
"2-7 j: jjjjjjjjjj",
"4-5 f: jfffqw",
"1-3 r: kwrrrrfwp",
"2-9 c: ccmcrthdqtk",
"13-15 w: wwwwwwwwwwwwrwwww",
"14-15 s: ssssssssssssssss",
"2-5 r: rhmrfmr",
"6-7 x: dwxgfpsbtvx",
"7-8 b: bbbbcbbb",
"1-5 l: slllcqlll",
"3-4 h: hhbr",
"3-6 k: kkkpkkk",
"2-5 s: nsssmsssbs",
"7-8 s: xtxtwtzspxsszmgjlpzx",
"2-4 r: jzqc",
"9-10 h: hhhhhhhbwh",
"8-13 g: xgzjgjgggggmgggzc",
"1-10 j: lrhzsjmfrzz",
"4-10 z: dkqdhhrszpcplmfqgg",
"7-9 x: xxxxxxwxxx",
"12-13 f: fffpfqcfbkdvsbtzwwf",
"5-8 g: ghsvggggzgggg",
"10-14 z: ctzzkszzzlzmzzzz",
"2-4 d: xfwdd",
"9-15 j: xjjdjcjhnjjjfjjj",
"1-2 h: hhhhhgwjhznh",
"9-13 d: kddddbdddxddjsdsdd",
"7-9 x: rxxxxdwxxxxnxkxcx",
"6-16 r: rlrtlkdftfgqpkrsljr",
"1-3 z: pzzz",
"5-6 h: krhbsh",
"8-9 x: mxqhpmqglxxwxqwxxxp",
"2-4 z: vmfj",
"12-15 s: sssfsssssksssst",
"3-5 f: fwhfb",
"10-12 j: jjjjjzwjjjjw",
"4-6 j: jjjjjjjjjjj",
"11-12 k: kkkkvfktkkkkkkwwzknk",
"5-8 m: mhhmbvmvms",
"10-14 r: rlwrdfzkhgrcrlz",
"5-6 h: hhhhfh",
"2-4 w: wwqhwww",
"1-5 x: nxxxwxx",
"11-16 h: xpshnhxbwclbhrhwsh",
"7-9 t: ttttflgtkh",
"10-20 n: bnknnnnnnlnnnnmnvncn",
"2-5 w: pwwhwkq",
"1-5 j: jhjjj",
"5-6 f: fzffzfwfr",
"3-6 s: sssssgs",
"9-10 w: wwwwwnwxbrww",
"5-6 z: xzzhzjzzzzhzhz",
"17-18 v: vvvvvvvvvvvvvvvtvbv",
"13-20 l: llllldllllllllllllll",
"8-14 k: kkkkkkkgkkkkkkkk",
"7-9 j: jjnjjjjjjj",
"7-14 j: tjbjljjrjjjjzjjjj",
"1-4 m: jcmmm",
"6-9 g: ggnggsghggg",
"2-16 v: pvvqdcrpzpsmppfvdftf",
"8-11 j: jjjjjjjjjvj",
"4-6 m: qbmmxmjpm",
"2-12 l: pllqdxmwfmmlmznqr",
"3-4 b: bsbhbbbbb",
"1-4 w: wwww",
"1-11 r: rrrrjrrrgmrr",
"3-8 t: tnrztcht",
"3-14 p: pjppkpplsphlpn",
"7-8 j: tdfcjdjbjjjvjj",
"10-11 n: nnnnnnmhnnnnrddrnn",
"1-7 p: tppgqppptqscprnp",
"3-4 c: cqcmcc",
"2-8 l: llllllrlll",
"9-12 j: dmcwsjjrvmzjp",
"4-8 h: hhhrhhhb",
"1-5 n: nnnnnn",
"5-6 s: srssss",
"2-8 n: nrbngnntnnn",
"1-13 f: bffmjfdfffffp",
"7-8 t: tqtttttt",
"3-4 x: xxhh",
"15-18 j: jjjjjjjjjjjjjjpjjk",
"7-9 v: vkvvmzvvv",
"5-7 j: xjjgkjknjjp",
"2-4 l: llslkh",
"10-11 m: mmmmmmmmmjwmmmwmm",
"5-6 j: pjjzjqbqv",
"5-11 n: nnnncnnnnnfnnnnnn",
"2-13 g: gdfrmlcszxcwj",
"9-16 b: bbbbbbwhpztbhdbzb",
"1-4 f: fffffc",
"1-3 f: fffkf",
"16-17 p: pppppppppppppppkt",
"6-10 h: wzcnzhvhml",
"1-9 f: ffffffffff",
"3-8 f: kffgggng",
"8-13 m: mmmmmmmmmmmmmm",
"12-19 k: zkzzlkkvpnllksklljr",
"1-4 j: jjmjjjjxjwj",
"4-5 h: phhhhzhhhmhhprh",
"11-12 p: ppppppppppvppp",
"13-16 j: hpgjjjwfhjgmdttl",
"2-4 w: wwjwhthzhvpmpfkw",
"9-10 k: kkxkkkkskkv",
"17-20 j: jjjjjjbjjjzjjjjjjjjj",
"1-3 v: cvvvb",
"5-8 s: zbnmbfgdp",
"10-11 x: xxxxgmdtxxtxxxbx",
"12-17 n: nmnnjcndnndcnncnnrnn",
"3-6 p: lmblxwpjvfgjps",
"9-12 s: ssssssssfsssw",
"9-10 g: ggggggwgkzgggg",
"5-12 m: pzmmmfxgvmtmlmq",
"2-7 p: ptppprn",
"9-10 c: bgqtkccxcqb",
"8-11 r: rdrrrrrhrrmr",
"7-9 w: wwqwwwfwwjwhgrw",
"5-7 r: rrrrrrh",
"2-10 s: rsflsvlwfs",
"3-7 b: bbqbbbb",
"11-12 m: mmjmmqmnmmmm",
"7-13 h: hhhhhhphhhnhghh",
"12-13 b: bbbbbbblbbbtk",
"5-13 h: ppgzjhhhlhhqx",
"14-19 q: qlbqmqqqjqqqqrqkjnq",
"3-19 f: pxmznsfdhzjqrdfjqrd",
"16-17 q: qqmdqrqqxcqfxfgjg",
"12-13 j: njjjzjghjjjjc",
"9-11 l: vmbsllkcshmrhklrl",
"1-2 c: tccccc",
"3-6 p: jspprpjxhn",
"5-8 x: xrxzxfwxxx",
"9-10 z: zdznzzzzzzzgzz",
"4-5 j: jjpjq",
"4-6 r: rcxscm",
"2-6 k: pkqjskrlfknnrqt",
"3-11 k: bqbskncdkfrphshvv",
"11-13 g: ggqgggggggggggg",
"6-14 f: fffdxmfffjfffmffff",
"19-20 z: zzzznzzzzzzzzzzzzzzz",
"5-8 j: jjjjjjjjjgjjjjjjjjj",
"2-4 k: pkbkqpsrgkcwc",
"8-12 b: dbbwtbwbqxvbwrbl",
"1-8 v: rvrvfcnlcwflcvlsv",
"4-5 f: hffhfkq",
"3-12 g: zggpngtnvzgd",
"4-8 t: ttttwrwt",
"12-13 x: xxxxxxxvxxxdnx",
"9-12 j: jrvjjjjjbjjp",
"1-13 b: zbhbbbbbbbbbvbb",
"1-2 w: wwwwwww",
"15-16 k: tfkxskmvqlkkmfkj",
"12-18 b: bdpxktjwpxhsbgmrfb",
"8-10 v: vvvvvvtzvzvv",
"18-19 g: ggglgggggggggggggggg",
"4-8 s: pnzsjvwsmxwgrjmsm",
"14-17 p: pppppxppppppppprpkp",
"9-17 n: nvlnqnwnnnztfcgnpdn",
"3-5 l: mlqflfl",
"7-11 z: dzzzzdmnzznzvzzz",
"14-16 r: xrrsvrhhrlnjjrvrr",
"12-14 z: vnwzqsvvtdnpvvdrhgz",
"1-4 h: mhhhh",
"1-5 m: pmmmmmm",
"6-11 j: jmkljhjjvjmfmjpj",
"2-4 f: xhtkdf",
"5-14 x: frqqxljjwsxndx"

        };
    }
}
