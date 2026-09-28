const http = require('http');

const HOST = process.env.HOST || '0.0.0.0';
const PORT = Number(process.env.PORT) || 3000;

const server = http.createServer((req, res) => {
	res.writeHead(200, { 'Content-Type': 'text/plain; charset=utf-8' });
	res.end('Server is running\n');
});

server.listen(PORT, HOST, () => {
	console.log(`Server listening on http://${HOST}:${PORT}`);
});

// THIS CODE WAS NOT WRITTEN BY ME. I cannot find the original source, as it's from a deleted account on Stack.