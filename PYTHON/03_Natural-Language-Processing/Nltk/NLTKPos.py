from nltk import pos_tag
from nltk import RegexpParser
text = "learn php from UldSkull and make study easy".split()
print("After split:", text)
token_tag = pos_tag(text)
print("After token:", token_tag)
patterns="""mychunk:{<NN.?>*<VBD.?>*<JJ.?>*<CC>?}"""
chunker = RegexpParser(patterns)
print("After Regex:", chunker)
output = chunker.parse(token_tag)
print("after chunking", output)