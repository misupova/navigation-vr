const { MongoClient, ObjectID } = require('mongodb')
const Express = require('express')
const BodyParser = require('body-parser')
require('dotenv').config()

const server = Express()
server.use(BodyParser.json())
server.use(BodyParser.urlencoded({ extended: true }))

const client = new MongoClient(process.env.DB_HOST, {
  useNewUrlParser: true,
  useUnifiedTopology: true,
})

server.post('/movement_data', async (request, response, next) => {
  try {
    let result = await collection.insertOne(request.body)

    response.send(result)
  } catch (e) {
    response.status(500).send({ message: e.message })
  }
})

server.listen('3000', async () => {
  try {
    await client.connect()

    const collection = client.db('navigation-vr').collection('movement_data')

    console.log('Listening at :3000...')
  } catch (e) {
    console.error(e)
  }
})
