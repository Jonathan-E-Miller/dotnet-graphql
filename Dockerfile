FROM mcr.microsoft.com/mssql/server:2022-latest as setup

# Set environment variables
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=YourStrong!Passw0rd
ENV MSSQL_PID=Developer

# Create a directory for backups
RUN mkdir -p /var/opt/mssql/backups

# Copy backup file to container
COPY Contoso.bak /var/opt/mssql/backups/

# Expose SQL Server port
EXPOSE 1433

# Have a stage specifically to populate the data directory
FROM setup AS data
USER mssql
# Break this down for my own knowlege... We
# 1 start sqlservr as a background task (daemon on linux).
# 2 the pipe | is passing the output from the background into the grep method -q for quiet. Waits here for a pattern match
# 3 the restore will not start until after the grep has a match due to the &&
RUN ( /opt/mssql/bin/sqlservr & ) | grep -q "Service Broker manager has started" \
    && /opt/mssql-tools18/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -C -Q 'RESTORE DATABASE Contoso FROM DISK = "/var/opt/mssql/backups/Contoso.bak" WITH MOVE "ContosoRetailDW2.0" TO "/var/opt/mssql/data/Contoso.mdf", MOVE "ContosoRetailDW2.0_log" TO "/var/opt/mssql/data/Contoso_log.ldf", NOUNLOAD, STATS = 5' \
    && pkill sqlservr