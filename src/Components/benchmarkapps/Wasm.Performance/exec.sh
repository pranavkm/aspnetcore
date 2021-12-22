#!/usr/bin/env bash

/opt/bin/start-selenium-standalone.sh &
cd /out/app/ && ./Wasm.Performance.Driver &&
cd /out/aot-app/ && ./Wasm.Performance.Driver
