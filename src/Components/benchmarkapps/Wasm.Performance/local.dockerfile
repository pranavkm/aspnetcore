FROM selenium/standalone-chrome:latest as final

ENV StressRunDuration=0

WORKDIR /app
COPY ./Driver/bin/Release/net7.0/linux-x64/publish ./
COPY ./local-exec.sh ./

ENTRYPOINT [ "bash", "./local-exec.sh" ]
