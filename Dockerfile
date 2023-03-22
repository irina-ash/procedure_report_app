FROM mcr.microsoft.com/mssql/server:2019-latest
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=admin
ENV MSSQL_PID=Developer
ENV MSSQL_TCP_PORT=1433
WORKDIR /app

RUN (/opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started"