const { MongoClient, ObjectID } = require('mongodb')
const Express = require('express')
const BodyParser = require('body-parser')
var cors = require('cors')
require('dotenv').config()

const server = Express()
server.use(BodyParser.json({ limit: '50mb' }))
server.use(
  BodyParser.urlencoded({
    limit: '50mb',
    extended: true,
    parameterLimit: 50000,
  }),
)
server.use(Express.json({ limit: '50mb' }))
server.use(Express.urlencoded({ limit: '50mb' }))
server.use(cors())

function clean(obj) {
  for (var propName in obj) {
    if (obj[propName] === null || obj[propName] === undefined || obj[propName] === "" || obj[propName] === 0) {
      delete obj[propName];
    }
  }
  return obj
}

const client = new MongoClient(process.env.DB_HOST, {
  useNewUrlParser: true,
  useUnifiedTopology: true,
})

var collection

server.post('/movement_data', async (request, response, next) => {
  try {
    console.log(request.body);
    let result = await collection.insertOne(request.body)
    response.send(result)
  } catch (e) {
    console.log(e)
    response.status(500).send({ message: e.message })
  }
})

server.put('/movement_data/:playerId', async (request, response, next) => {
  try {
    console.log(request.body);
    let result = await collection.updateOne(
      { playerId: request.params.playerId },
      { $set: clean(request.body) },
    )
    response.send(result)
  } catch (e) {
    console.log(e)
    response.status(500).send({ message: e.message })
  }
})

server.get('/generate_level', (req, res) => {
  res.send(String(Math.floor(Math.random() * 2) + 1));
})

server.listen('3000', async () => {
  try {
    await client.connect()

    collection = client.db('navigation-vr').collection('movement_data')

    console.log('Listening at :3000...')
  } catch (e) {
    console.error(e)
  }
})
