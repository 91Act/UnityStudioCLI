from os import walk
import os
rootPath = ""
'''
Recursively dump the ab files under rootPath
'''

f = []
def walk(top, maxdepth):
    dirs, nondirs = [], []
    for name in os.listdir(top):
        (dirs if os.path.isdir(os.path.join(top, name)) else nondirs).append(name)
    yield top, dirs, nondirs
    if maxdepth > 1:
        for name in dirs:
            if name.startswith('.DS'):
                continue
            if name.startswith('CAB'):
                continue
            for x in walk(os.path.join(top, name), maxdepth-1):
                yield x

for x in walk(rootPath, 100):
    print "-"*64
    path = x[0]
    for file in x[2]:
        if file.endswith('.manifest'):
            continue
        abpath = path+'/'+file
        print abpath
        os.system('mono --debug adebug -dump '+abpath)